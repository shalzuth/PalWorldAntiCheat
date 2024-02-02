﻿using SDK.Script.CoreUObjectSDK;
using SDK.Script.PalSDK;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using static UnrealSharp.Memory;
using static UnrealSharp.UnrealEngine;

namespace UnrealSharp
{
    public class UnrealEngine
    {
        public static UnrealEngine Instance;
        static nint GNamesPattern;
        public static nint GNames;
        static nint GObjectsPattern;
        public static nint GObjects;
        static nint GWorldPtrPattern;
        public static nint GWorldPtr;
        static nint GEnginePattern;
        public static nint GEngine;
        public static nint GStaticCtor;
        public static Memory Memory;
        //public static nint FStringCtor;
        //public static nint FTextCtor;
        public delegate void FStringFromStringDelegate(nint fString, byte[] wChar);
        public static FStringFromStringDelegate FString;
        public delegate nint FTextFromFStringDelegate(nint fText, nint fString);
        public static FTextFromFStringDelegate FText;
        public UnrealEngine(Memory mem) { Memory = mem; Instance = this; }
        public void UpdateAddresses()
        {
            {
                GNamesPattern = Memory.FindPattern("74 09 48 8D 15 ? ? ? ? EB 16");
                var offset = Memory.ReadProcessMemory<int>(GNamesPattern + 5);
                GNames = GNamesPattern + offset + 9;
                if (UEObject.GetName(3) != "ByteProperty") throw new Exception("bad GNames");
                //DumpGNames();
            }
            {
                var stringAddr = Memory.FindStringRef("    SeamlessTravel FlushLevelStreaming");
                GWorldPtrPattern = Memory.FindPattern("48 89 05", stringAddr - 0x500, 0x500);
                //GWorldPtrPattern = Memory.FindPattern("48 89 05 ? ? ? ? 48 8B 76 78 F6 86");
                GObjectsPattern = Memory.FindPattern("48 8B 05 ? ? ? ? 48 8B 0C C8 ? 8D 04 D1 EB ?");

                var offset = UnrealEngine.Memory.ReadProcessMemory<int>(GWorldPtrPattern + 3);
                GWorldPtr = GWorldPtrPattern + offset + 7;
                UpdateUEObject();

                offset = Memory.ReadProcessMemory<int>(GObjectsPattern + 3);
                GObjects = GObjectsPattern + offset + 7 - Memory.BaseAddress;
            }
            {
                GEnginePattern = Memory.FindPattern("48 8B 0D ?? ?? ?? ?? 48 85 C9 74 1E 48 8B 01 FF 90");
                var offset = Memory.ReadProcessMemory<int>(GEnginePattern + 3);
                GEngine = Memory.ReadProcessMemory<nint>(GEnginePattern + offset + 7);
            }
            {
                var engine = new UEObject(GEngine);
                GStaticCtor = Memory.FindPattern("4C 89 44 24 18 55 53 56 57 41 54 41 55 41 56 41 57 48 8D AC 24 ? ? ? ? 48 81 EC ? ? ? ? 48 8B 05 ? ? ? ? 48 33 C4");
            }
            {
                var FStringCtor = Memory.FindPattern("48 89 74 24 ? 57 48 83 EC 20 33 C0 48 8B F2 48 89 01 48 8B F9 48 89 41 08 48 85 D2 74 64");
                var FTextCtors = Memory.FindPatterns("48 89 5C 24 ? 48 89 6C 24 ? 56 48 83 EC 60 33");
                var FTextCtor = FTextCtors[1];
                FString = Marshal.GetDelegateForFunctionPointer<FStringFromStringDelegate>(FStringCtor);
                FText = Marshal.GetDelegateForFunctionPointer<FTextFromFStringDelegate>(FTextCtor);

            }
            //DumpSdk();
        }
        public void EnableConsole()
        {
            var engine = new UEObject(GEngine);
            //var console = new UEObject(Memory.Execute(GStaticCtor, engine["ConsoleClass"].Value, engine["GameViewport"].Address, 0, 0, 0, 0, 0, 0, 0));
            //engine["GameViewport"]["ViewportConsole"] = console;
        }
        public void UpdateUEObject()
        {
            var world = Memory.ReadProcessMemory<nint>(GWorldPtr);
            {
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                var foundClassAndName = false;
                for (var c = 0; c < 0x50 && !foundClassAndName; c += 0x8)
                {
                    classPtr = Memory.ReadProcessMemory<nint>(world + c);
                    if (classPtr == 0x0) continue;
                    for (var n = 0; n < 0x50 && !foundClassAndName; n += 0x8)
                    {
                        var classNameIndex = Memory.ReadProcessMemory<int>(classPtr + n);
                        var name = UEObject.GetName(classNameIndex);
                        if (name == "World")
                        {
                            UEObject.classOffset = c;
                            UEObject.nameOffset = n;
                            foundClassAndName = true;
                        }
                    }
                }
                if (!foundClassAndName) throw new Exception("bad World or offsets?");
            }
            {
                var foundOuter = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                for (var o = 0; o < 0x50; o += 0x8)
                {
                    var outerObj = Memory.ReadProcessMemory<nint>(classPtr + o);
                    var classNameIndex = Memory.ReadProcessMemory<int>(outerObj + UEObject.nameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "/Script/Engine")
                    {
                        UEObject.objectOuterOffset = o;
                        foundOuter = true;
                        break;
                    }
                }
                if (!foundOuter) throw new Exception("bad outer addr");
            }
            {
                var foundSuper = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                for (var o = 0; o < 0x50; o += 0x8)
                {
                    var superObj = Memory.ReadProcessMemory<nint>(classPtr + o);
                    var classNameIndex = Memory.ReadProcessMemory<int>(superObj + UEObject.nameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "Object")
                    {
                        UEObject.structSuperOffset = o;
                        foundSuper = true;
                        break;
                    }
                }
                if (!foundSuper) throw new Exception("bad super addr");
            }
            {
                var foundChildsAndFieldName = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                for (var c = 0; c < 0x80 && !foundChildsAndFieldName; c += 0x8)
                {
                    var childPtr = Memory.ReadProcessMemory<nint>(classPtr + c);
                    if (childPtr == 0x0) continue;
                    for (var n = 0; n < 0x80 && !foundChildsAndFieldName; n += 0x8)
                    {
                        var classNameIndex = Memory.ReadProcessMemory<int>(childPtr + n);
                        var name = UEObject.GetName(classNameIndex);
                        if (name == "PersistentLevel")
                        {
                            UEObject.childPropertiesOffset = c;
                            UEObject.fieldNameOffset = n;
                            foundChildsAndFieldName = true;
                        }
                    }
                }
                if (!foundChildsAndFieldName) throw new Exception("bad childs offset");
            }
            {
                var foundNextField = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                var fieldPtr = Memory.ReadProcessMemory<nint>(classPtr + UEObject.childPropertiesOffset);
                for (var c = 0; c < 0x80 && !foundNextField; c += 0x8)
                {
                    var childClassPtr = Memory.ReadProcessMemory<nint>(fieldPtr + c);
                    if (childClassPtr == 0x0) continue;
                    var classNameIndex = Memory.ReadProcessMemory<int>(childClassPtr + UEObject.fieldNameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "NetDriver")
                    {
                        UEObject.fieldNextOffset = c;
                        foundNextField = true;
                    }
                }
                if (!foundNextField) throw new Exception("bad next field offset");
            }
            {
                var foundFuncs = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                for (var c = 0; c < 0x80 && !foundFuncs; c += 0x8)
                {
                    var childPtr = Memory.ReadProcessMemory<nint>(classPtr + c);
                    if (childPtr == 0x0) continue;
                    var classNameIndex = Memory.ReadProcessMemory<int>(childPtr + UEObject.nameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "K2_GetWorldSettings")
                    {
                        UEObject.childrenOffset = c;
                        foundFuncs = true;
                    }
                }
                if (!foundFuncs)
                {
                    var testObj = new UEObject(world);
                    var isField = testObj["K2_GetWorldSettings"];
                    if (isField != null)
                    {
                        UEObject.childrenOffset = UEObject.childPropertiesOffset;
                        foundFuncs = true;
                    }
                }
                if (!foundFuncs) throw new Exception("bad childs offset");
            }
            {
                var foundNextField = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                var fieldPtr = Memory.ReadProcessMemory<nint>(classPtr + UEObject.childrenOffset);
                for (var c = 0; c < 0x80 && !foundNextField; c += 0x8)
                {
                    var childClassPtr = Memory.ReadProcessMemory<nint>(fieldPtr + c);
                    if (childClassPtr == 0x0) continue;
                    var classNameIndex = Memory.ReadProcessMemory<int>(childClassPtr + UEObject.nameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "HandleTimelineScrubbed")
                    {
                        UEObject.funcNextOffset = c;
                        foundNextField = true;
                    }
                }
                if (!foundNextField) throw new Exception("bad next offset");
            }
            {
                var foundNextField = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                var fieldPtr = Memory.ReadProcessMemory<nint>(classPtr + UEObject.childPropertiesOffset);
                for (var c = 0; c < 0x80 && !foundNextField; c += 0x8)
                {
                    var childClassPtr = Memory.ReadProcessMemory<nint>(fieldPtr + c);
                    if (childClassPtr == 0x0) continue;
                    var classNameOffset = UEObject.NewFName ? 0 : UEObject.fieldNameOffset;
                    var classNameIndex = Memory.ReadProcessMemory<int>(childClassPtr + classNameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "ObjectProperty")
                    {
                        UEObject.fieldClassOffset = c;
                        foundNextField = true;
                    }
                }
                if (!foundNextField) throw new Exception("bad field class offset");
            }
            {
                var foundFieldOffset = false;
                var classPtr = Memory.ReadProcessMemory<nint>(world + UEObject.classOffset);
                var fieldPtr = Memory.ReadProcessMemory<nint>(classPtr + UEObject.childPropertiesOffset);
                for (var c = 0x0; c < 0x80 && !foundFieldOffset; c += 0x4)
                {
                    var fieldOffset = Memory.ReadProcessMemory<nint>(fieldPtr + c);
                    var nextFieldPtr = Memory.ReadProcessMemory<nint>(fieldPtr + UEObject.fieldNextOffset);
                    var fieldOffsetPlus8 = Memory.ReadProcessMemory<nint>(nextFieldPtr + c);
                    if ((fieldOffset + 8) == fieldOffsetPlus8)
                    {
                        UEObject.fieldOffset = c;
                        foundFieldOffset = true;
                    }
                }
                if (!foundFieldOffset) throw new Exception("bad field offset");
            }
            {
                var World = new UEObject(world);
                var field = World.GetFieldAddr("StreamingLevelsToConsider");
                var foundPropertySize = false;
                for (var c = 0x60; c < 0x100 && !foundPropertySize; c += 0x8)
                {
                    var classAddr = Memory.ReadProcessMemory<nint>(field + c);
                    var classNameIndex = Memory.ReadProcessMemory<Int32>(classAddr + UEObject.nameOffset);
                    var name = UEObject.GetName(classNameIndex);
                    if (name == "StreamingLevelsToConsider")
                    {
                        UEObject.propertySize = c;
                        foundPropertySize = true;
                    }
                }
                if (!foundPropertySize) throw new Exception("bad property size offset");
            }
            {
                var vTable = UnrealEngine.Memory.ReadProcessMemory<nint>(world);
                var foundProcessEventOffset = false;
                for (var i = 50; i < 0x100 && !foundProcessEventOffset; i++)
                {
                    var s = UnrealEngine.Memory.ReadProcessMemory<IntPtr>(vTable + i * 8);
                    var sig = (UInt64)UnrealEngine.Memory.FindPattern("40 55 56 57 41 54 41 55 41 56 41 57", s, 0X20);
                    if (sig != 0)
                    {
                        UEObject.vTableFuncNum = i;
                        foundProcessEventOffset = true;
                    }
                }
                if (!foundProcessEventOffset) throw new Exception("bad process event offset");
            }
            {
                var testObj = new UEObject(world);
                var funcAddr = testObj.GetFuncAddr(testObj.ClassAddr, testObj.ClassAddr, "K2_GetWorldSettings");
                var foundFuncFlags = false;
                for (var i = 0; i < 0x200 && !foundFuncFlags; i += 8)
                {
                    var flags = UnrealEngine.Memory.ReadProcessMemory<nint>(funcAddr + i);
                    if (flags == 0x0008000104020401)
                    {
                        UEObject.funcFlagsOffset = i;
                        foundFuncFlags = true;
                    }
                }
                if (!foundFuncFlags) throw new Exception("bad func flags offset");
            }
        }
        public void DumpGNames()
        {
            var testObj = new UEObject(0);
            var sb = new StringBuilder();
            var i = 0;
            while (true)
            {
                var name = UEObject.GetName(i);

                if (name == "badIndex")
                {
                    if ((i & 0xffff) > 0xff00)
                    {
                        i += 0x10000 - (i % 0x10000);
                        continue;
                    }
                    break;
                }
                sb.AppendLine("[" + i + " | " + (i).ToString("X") + "] " + name);
                i += name.Length / 2 + name.Length % 2 + 1;
            }
            System.IO.Directory.CreateDirectory(Memory.Process.ProcessName);
            System.IO.File.WriteAllText(Memory.Process.ProcessName + @"\GNamesDump.txt", sb.ToString());
        }
        public String GetTypeFromFieldAddr(String fName, String fType, nint fAddr, out String gettersetter)
        {
            gettersetter = "";
            if (fType == "BoolProperty")
            {
                fType = "bool";
                gettersetter = "{ get { return this[nameof(" + fName + ")].Flag; } set { this[nameof(" + fName + ")].Flag = value; } }";
            }
            else if (fType == "ByteProperty" || fType == "Int8Property")
            {
                fType = "byte";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "Int16Property")
            {
                fType = "short";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "UInt16Property")
            {
                fType = "ushort";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "IntProperty")
            {
                fType = "int";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "UInt32Property")
            {
                fType = "uint";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "Int64Property")
            {
                fType = "long";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "UInt64Property")
            {
                fType = "ulong";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "FloatProperty")
            {
                fType = "float";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "DoubleProperty")
            {
                fType = "double";
                gettersetter = "{ get { return this[nameof(" + fName + ")].GetValue<" + fType + ">(); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
            }
            else if (fType == "StrProperty")
            {
                fType = "unk";
            }
            else if (fType == "TextProperty")
            {
                fType = "unk";
            }
            else if (fType == "ObjectProperty")
            {
                var structFieldIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(UnrealEngine.Memory.ReadProcessMemory<nint>(fAddr + UEObject.propertySize) + UEObject.nameOffset);
                fType = UEObject.GetName(structFieldIndex);
                gettersetter = "{ get { return this[nameof(" + fName + ")].As<" + fType + ">(); } set { this[\"" + fName + "\"] = value; } }";
            }
            else if (fType == "ClassPtrProperty")
            {
                fType = "Object";
                gettersetter = "{ get { return this[nameof(" + fName + ")].As<" + fType + ">(); } set { this[\"" + fName + "\"] = value; } } // ClassPtrProperty";
            }
            else if (fType == "ScriptTypedElementHandle")
            {
                fType = "Object";
                gettersetter = "{ get { return this[nameof(" + fName + ")].As<" + fType + ">(); } set { this[\"" + fName + "\"] = value; } } // ClassPtrProperty";
            }
            else if (fType == "StructProperty")
            {
                var structFieldIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(UnrealEngine.Memory.ReadProcessMemory<nint>(fAddr + UEObject.propertySize) + UEObject.nameOffset);
                fType = UEObject.GetName(structFieldIndex);
                //gettersetter = "{ get { return UnrealEngine.Memory.ReadProcessMemory<" + fType + ">(this[nameof(" + fName + ")].Address); } set { this[nameof(" + fName + ")].SetValue<" + fType + ">(value); } }";
                gettersetter = "{ get { return this[nameof(" + fName + ")].As<" + fType + ">(); } set { this[\"" + fName + "\"] = value; } }";
            }
            else if (fType == "EnumProperty")
            {
                var structFieldIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(UnrealEngine.Memory.ReadProcessMemory<nint>(fAddr + UEObject.propertySize + 8) + UEObject.nameOffset);
                fType = UEObject.GetName(structFieldIndex);
                gettersetter = "{ get { return (" + fType + ")this[nameof(" + fName + ")].GetValue<int>(); } set { this[nameof(" + fName + ")].SetValue<int>((int)value); } }";
            }
            else if (fType == "NameProperty")
            {
                fType = "unk";
            }
            else if (fType == "ArrayProperty")
            {
                var inner = UnrealEngine.Memory.ReadProcessMemory<nint>(fAddr + UEObject.propertySize);
                var innerClass = UnrealEngine.Memory.ReadProcessMemory<nint>(inner + UEObject.fieldClassOffset);
                var structFieldIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(innerClass);
                fType = UEObject.GetName(structFieldIndex);
                var innerType = GetTypeFromFieldAddr(fName, fType, inner, out gettersetter);
                gettersetter = "{ get { return new Array<" + innerType + ">(this[nameof(" + fName + ")].Address); } }";// set { this[\"" + fName + "\"] = value; } }";
                fType = "Array<" + innerType + ">";
            }
            else if (fType == "SoftObjectProperty")
            {
                fType = "unk";
            }
            else if (fType == "SoftClassProperty")
            {
                fType = "unk";
            }
            else if (fType == "WeakObjectProperty")
            {
                fType = "unk";
            }
            else if (fType == "LazyObjectProperty")
            {
                fType = "unk";
            }
            else if (fType == "DelegateProperty")
            {
                fType = "unk";
            }
            else if (fType == "MulticastSparseDelegateProperty")
            {
                fType = "unk";
            }
            else if (fType == "MulticastInlineDelegateProperty")
            {
                fType = "unk";
            }
            else if (fType == "ClassProperty")
            {
                fType = "unk";
            }
            else if (fType == "MapProperty")
            {
                fType = "unk";
            }
            else if (fType == "SetProperty")
            {
                fType = "unk";
            }
            else if (fType == "FieldPathProperty")
            {
                fType = "unk";
            }
            else if (fType == "InterfaceProperty")
            {
                fType = "unk";
            }
            else if (fType == "Enum")
            {
                fType = "UEEnum";
            }
            else if (fType == "DateTime")
            {
                fType = "UEDateTime";
            }
            else if (fType == "Guid")
            {
                fType = "UEGuid";
            }
            if (fType == "unk")
            {
                fType = "Object";
                gettersetter = "{ get { return this[nameof(" + fName + ")]; } set { this[nameof(" + fName + ")] = value; } }";
            }
            return fType;
        }
        public class Package
        {
            public String FullName;
            public String Name => FullName.Substring(FullName.LastIndexOf("/") + 1);
            public List<SDKClass> Classes = new List<SDKClass>();
            public List<Package> Dependencies = new List<Package>();
            public class SDKClass
            {
                public String SdkType;
                public String Namespace;
                public String Name;
                public String Parent;
                public List<SDKFields> Fields = new List<SDKFields>();
                public List<SDKFunctions> Functions = new List<SDKFunctions>();
                public class SDKFields
                {
                    public String Type;
                    public String Name;
                    public String GetterSetter;
                    public Int32 EnumVal;
                }
                public class SDKFunctions
                {
                    public String ReturnType;
                    public String Name;
                    public List<SDKFields> Params = new List<SDKFields>();
                }

            }
        }
        public void DumpSdk(String location = "")
        {
            if (location == "") location = Memory.Process.ProcessName;
            Directory.CreateDirectory(location);
            var entityList = Memory.ReadProcessMemory<nint>(Memory.BaseAddress + GObjects);
            var count = Memory.ReadProcessMemory<UInt32>(Memory.BaseAddress + GObjects + 0x14);
            entityList = Memory.ReadProcessMemory<nint>(entityList);
            var packages = new Dictionary<nint, List<nint>>();
            for (var i = 0; i < count; i++)
            {
                // var entityAddr = Memory.ReadProcessMemory<UInt64>((entityList + 8 * (i / 0x10400)) + 24 * (i % 0x10400));
                var entityAddr = Memory.ReadProcessMemory<nint>((entityList + 8 * (i >> 16)) + 24 * (i % 0x10000));
                if (entityAddr == 0) continue;
                var outer = entityAddr;
                while (true)
                {
                    var tempOuter = Memory.ReadProcessMemory<nint>(outer + UEObject.objectOuterOffset);
                    if (tempOuter == 0) break;
                    outer = tempOuter;
                }
                if (!packages.ContainsKey(outer)) packages.Add(outer, new List<nint>());
                packages[outer].Add(entityAddr);
            }
            var ii = 0;
            var dumpedPackages = new List<Package>();
            foreach (var package in packages)
            {
                var packageObj = new UEObject(package.Key);
                var fullPackageName = packageObj.GetName();
                if (fullPackageName.Contains("TypedElementFrameworkSDK"))
                    Console.WriteLine("");
                var dumpedClasses = new List<String>();
                var sdkPackage = new Package { FullName = fullPackageName };
                foreach (var objAddr in package.Value)
                {
                    var obj = new UEObject(objAddr);
                    if (dumpedClasses.Contains(obj.ClassName)) continue;
                    dumpedClasses.Add(obj.ClassName);
                    if (obj.ClassName.StartsWith("Package")) continue;
                    var typeName = obj.ClassName.StartsWith("Class") ? "class" : obj.ClassName.StartsWith("ScriptStruct") ? "class" : obj.ClassName.StartsWith("Enum") ? "enum" : "unk";
                    //if (obj.ClassName.StartsWith("BlueprintGenerated")) typeName = "class";
                    var className = obj.GetName();
                    if (typeName == "unk") continue;
                    if (className == "Object") continue;
                    var parentClass = UnrealEngine.Memory.ReadProcessMemory<nint>(obj.Address + UEObject.structSuperOffset);
                    var sdkClass = new Package.SDKClass { Name = className, Namespace = fullPackageName, SdkType = typeName };
                    if (typeName == "enum") sdkClass.Parent = "int";
                    else if (parentClass != 0)
                    {
                        var parentNameIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(parentClass + UEObject.nameOffset);
                        var parentName = UEObject.GetName(parentNameIndex);
                        sdkClass.Parent = parentName;
                    }
                    else sdkClass.Parent = "Object";
                    //else throw new Exception("unparented obj not supported");

                    if (typeName == "enum")
                    {
                        var enumArray = UnrealEngine.Memory.ReadProcessMemory<nint>(objAddr + 0x40);
                        var enumCount = UnrealEngine.Memory.ReadProcessMemory<int>(objAddr + 0x48);
                        for (var i = 0; i < enumCount; i++)
                        {
                            var enumNameIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(enumArray + i * 0x10);
                            var enumName = UEObject.GetName(enumNameIndex);
                            enumName = enumName.Substring(enumName.LastIndexOf(":") + 1);
                            var enumNameRepeatedIndex = UnrealEngine.Memory.ReadProcessMemory<Int32>(enumArray + i * 0x10 + 4);
                            if (enumNameRepeatedIndex > 0)
                                enumName += "_" + enumNameRepeatedIndex;
                            var enumVal = UnrealEngine.Memory.ReadProcessMemory<Int32>(enumArray + i * 0x10 + 0x8);
                            sdkClass.Fields.Add(new Package.SDKClass.SDKFields { Name = enumName, EnumVal = enumVal });
                        }
                    }
                    else if (typeName == "unk")
                    {
                        continue;
                    }
                    else
                    {
                        var field = obj.Address + UEObject.childPropertiesOffset - UEObject.fieldNextOffset;
                        while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + UEObject.fieldNextOffset)) > 0)
                        {
                            var fName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<Int32>(field + UEObject.fieldNameOffset));
                            var fType = obj.GetFieldType(field);
                            var fValue = "(" + field.ToString() + ")";
                            var offset = (UInt32)obj.GetFieldOffset(field);
                            var gettersetter = "{ get { return new {0}(this[\"{1}\"].Address); } set { this[\"{1}\"] = value; } }";
                            fType = GetTypeFromFieldAddr(fName, fType, field, out gettersetter);
                            //if (typeName == "struct") gettersetter = ";";
                            if (fName == className) fName += "_value";
                            sdkClass.Fields.Add(new Package.SDKClass.SDKFields { Type = fType, Name = fName, GetterSetter = gettersetter });
                        }
                        field = obj.Address + UEObject.childrenOffset - UEObject.funcNextOffset;
                        while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + UEObject.funcNextOffset)) > 0)
                        {
                            var fName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<Int32>(field + UEObject.nameOffset));
                            if (fName == className) fName += "_value";
                            var func = new Package.SDKClass.SDKFunctions { Name = fName };
                            var fField = field + UEObject.childPropertiesOffset - UEObject.fieldNextOffset;
                            while ((fField = UnrealEngine.Memory.ReadProcessMemory<nint>(fField + UEObject.fieldNextOffset)) > 0)
                            {
                                var pName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<Int32>(fField + UEObject.fieldNameOffset));
                                var pType = obj.GetFieldType(fField);
                                pType = GetTypeFromFieldAddr("", pType, fField, out _);
                                func.Params.Add(new Package.SDKClass.SDKFields { Name = pName, Type = pType });
                            }
                            sdkClass.Functions.Add(func);
                        }
                    }
                    sdkPackage.Classes.Add(sdkClass);
                }
                dumpedPackages.Add(sdkPackage);
            }
            foreach (var p in dumpedPackages)
            {
                p.Dependencies = new List<Package>();
                foreach (var c in p.Classes)
                {
                    {
                        var fromPackage = dumpedPackages.Find(tp => tp.Classes.Count(tc => tc.Name == c.Parent) > 0);
                        if (fromPackage != null && fromPackage != p && !p.Dependencies.Contains(fromPackage)) p.Dependencies.Add(fromPackage);
                    }
                    foreach (var f in c.Fields)
                    {
                        var fromPackage = dumpedPackages.Find(tp => tp.Classes.Count(tc => tc.Name == f.Type?.Replace("Array<", "").Replace(">", "")) > 0);
                        if (fromPackage != null && fromPackage != p && !p.Dependencies.Contains(fromPackage)) p.Dependencies.Add(fromPackage);
                    }
                    foreach (var f in c.Functions)
                    {
                        foreach (var param in f.Params)
                        {
                            var fromPackage = dumpedPackages.Find(tp => tp.Classes.Count(tc => tc.Name == param.Type?.Replace("Array<", "").Replace(">", "")) > 0);
                            if (fromPackage != null && fromPackage != p && !p.Dependencies.Contains(fromPackage)) p.Dependencies.Add(fromPackage);
                        }
                    }
                }
            }
            foreach (var p in dumpedPackages)
            {
                var sb = new StringBuilder();
                sb.AppendLine("using UnrealSharp;");
                sb.AppendLine("using Object = UnrealSharp.UEObject;");
                sb.AppendLine("using Guid = SDK.Script.CoreUObjectSDK.Guid;");
                sb.AppendLine("using Enum = SDK.Script.CoreUObjectSDK.Enum;");
                sb.AppendLine("using DateTime = SDK.Script.CoreUObjectSDK.DateTime;");
                foreach (var d in p.Dependencies) sb.AppendLine("using SDK" + d.FullName.Replace("/", ".") + "SDK;");
                sb.AppendLine("namespace SDK" + p.FullName.Replace("/", ".") + "SDK");
                sb.AppendLine("{");
                var printedClasses = 0;
                foreach (var c in p.Classes)
                {
                    if (c.Fields.Count > 0) printedClasses++;
                    // sb.AppendLine("    [Namespace(\"" + c.Namespace + "\")]");
                    sb.AppendLine("    public " + c.SdkType + " " + c.Name + ((c.Parent == null) ? "" : (" : " + c.Parent)));
                    sb.AppendLine("    {");
                    if (c.SdkType != "enum")
                        sb.AppendLine("        public " + c.Name + "(nint addr) : base(addr) { }");
                    foreach (var f in c.Fields)
                    {
                        if (f.Name == "RelatedPlayerState") continue; // todo fix
                        if (c.SdkType == "enum")
                            sb.AppendLine("        " + f.Name + " = " + f.EnumVal + ",");
                        else if (f.Name.StartsWith("__") || f.Name.StartsWith("Float") || f.Name == "float" || f.Name == "bool" || f.Name == "None")
                            sb.AppendLine("        //public " + f.Type + " " + f.Name + " " + f.GetterSetter);
                        else
                            sb.AppendLine("        public " + f.Type + " " + f.Name + " " + f.GetterSetter);
                    }
                    foreach (var f in c.Functions)
                    {
                        if (f.Name == "ClientReceiveLocalizedMessage") continue; // todo fix
                        var returnType = f.Params.FirstOrDefault(pa => pa.Name == "ReturnValue")?.Type ?? "void";
                        var parameters = String.Join(", ", f.Params.FindAll(pa => pa.Name != "ReturnValue").Select(pa => pa.Type + " " + pa.Name));
                        var args = f.Params.FindAll(pa => pa.Name != "ReturnValue").Select(pa => pa.Name).ToList();
                        args.Insert(0, "nameof(" + f.Name + ")");
                        var argList = String.Join(", ", args);
                        var returnTypeTemplate = returnType == "void" ? "" : ("<" + returnType + ">");
                        if (parameters.Contains("bool bool") || parameters.Contains("float float") || parameters.Contains("ScriptTypedElementListProxy") || parameters.Contains("ScriptTypedElementHandle") || returnType.Contains("AudioLinkSettingsAbstract") || returnType.Contains("ScriptTypedElementHandle") || returnType.Contains("ScriptTypedElementListProxy"))
                            sb.AppendLine("        //public " + returnType + " " + f.Name + "(" + parameters + ") { " + (returnType == "void" ? "" : "return ") + "Invoke" + returnTypeTemplate + "(" + argList + "); }");
                        else
                            sb.AppendLine("        public " + returnType + " " + f.Name + "(" + parameters + ") { " + (returnType == "void" ? "" : "return ") + "Invoke" + returnTypeTemplate + "(" + argList + "); }");
                    }
                    sb.AppendLine("    }");
                }
                sb.AppendLine("}");
                if (printedClasses == 0)
                    continue;
                System.IO.File.WriteAllText(location + @"\" + p.Name + ".cs", sb.ToString());
            }
        }
    }
    public class Array<T> : UEObject
    {
        public Array(UEObject obj) : base()
        {
            Address = obj.Address;
            _classAddr = obj.ClassAddr;
            _substructAddr = obj._substructAddr;
        }
        public Array(nint addr) : base(addr) { }
        public Array(nint addr, nint classAddr) : base(addr) { _classAddr = classAddr; }
        public int Num
        {
            get
            {
                if (_num != int.MaxValue) return _num;
                _num = UnrealEngine.Memory.ReadProcessMemory<int>(Address + 8);
                if (_num > 0x20000) _num = 0x20000;
                return _num;
            }
        }
        public Byte[] ArrayCache
        {
            get
            {
                if (_arrayCache.Length != 0) return _arrayCache;
                _arrayCache = UnrealEngine.Memory.ReadProcessMemory(Value, Num * 8);
                return _arrayCache;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= Num) return (T)Activator.CreateInstance(typeof(T), (nint)0);
                return (T)Activator.CreateInstance(typeof(T), (nint)BitConverter.ToUInt64(ArrayCache, index * 8));
            }
        }
        public T this[int index, bool t]
        {
            get
            {
                if (typeof(T).IsAssignableTo(typeof(UEObject)))
                {
                    var subStructSize = 0x28;// (int)typeof(T).GetField("size").GetValue(null);
                    var obj = (T)Activator.CreateInstance(typeof(T), (nint)Value + index * subStructSize);
                    var q = obj as UEObject;
                    q._classAddr = _substructAddr;
                    obj = (T)(object)q;
                    return obj;
                }
                else
                {
                    var obj = (T)Activator.CreateInstance(typeof(T), (nint)Value + index * Marshal.SizeOf(typeof(T)));
                    return obj;

                }
            }
        }
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
    public class NamespaceAttribute : Attribute
    {
        public string name;
        public NamespaceAttribute(string name)
        {
            this.name = name;
        }
    }
    public class UEObject
    {
        public static int objectOuterOffset = 0x20;
        public static int classOffset = 0x10;
        public static int nameOffset = 0x18;
        public static int structSuperOffset = 0x40;
        public static int childPropertiesOffset = 0x50;
        public static int childrenOffset = 0x48;
        public static int fieldNameOffset = 0x28;
        public static int fieldTypeNameOffset = 0;
        public static int fieldClassOffset = 0x8;
        public static int fieldNextOffset = 0x20;
        public static int funcNextOffset = 0x20;
        public static int fieldOffset = 0x4C;
        public static int propertySize = 0x78;
        public static int vTableFuncNum = 66;
        public static int funcFlagsOffset = 0xB0;
        public static int enumArrayOffset = 0x40;
        public static int enumCountOffset = 0x48;

        static ConcurrentDictionary<nint, string> AddrToName = new ConcurrentDictionary<nint, string>();
        static ConcurrentDictionary<nint, nint> AddrToClass = new ConcurrentDictionary<nint, nint>();
        static ConcurrentDictionary<String, Boolean> ClassIsSubClass = new ConcurrentDictionary<string, bool>();
        static ConcurrentDictionary<nint, string> ClassToName = new ConcurrentDictionary<nint, string>();
        static ConcurrentDictionary<nint, ConcurrentDictionary<string, nint>> ClassFieldToAddr = new ConcurrentDictionary<nint, ConcurrentDictionary<string, nint>>();
        static ConcurrentDictionary<nint, int> FieldAddrToOffset = new ConcurrentDictionary<nint, int>();
        static ConcurrentDictionary<nint, string> FieldAddrToType = new ConcurrentDictionary<nint, string>();
        public static void ClearCache()
        {
            AddrToName.Clear();
            AddrToClass.Clear();
            ClassIsSubClass.Clear();
            //ClassToAddr.Clear();
            ClassFieldToAddr.Clear();
            FieldAddrToOffset.Clear();
            FieldAddrToType.Clear();
        }
        public int GetFieldOffset(nint fieldAddr)
        {
            if (FieldAddrToOffset.ContainsKey(fieldAddr)) return FieldAddrToOffset[fieldAddr];
            var offset = UnrealEngine.Memory.ReadProcessMemory<int>(fieldAddr + fieldOffset);
            FieldAddrToOffset[fieldAddr] = offset;
            return offset;
        }
        String _className;
        public String ClassName
        {
            get
            {
                if (_className != null) return _className;
                _className = GetFullPath();// GetFullName(ClassAddr);
                return _className;
            }
        }
        public nint _substructAddr = nint.MaxValue;
        public nint _classAddr = nint.MaxValue;
        public nint ClassAddr
        {
            get
            {
                if (_classAddr != nint.MaxValue) return _classAddr;
                if (AddrToClass.ContainsKey(Address))
                {
                    _classAddr = AddrToClass[Address];
                    return _classAddr;
                }
                _classAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(Address + classOffset);
                AddrToClass[Address] = _classAddr;
                return _classAddr;
            }
        }
        public UEObject(nint address = 0)
        {
            Address = address;
        }
        public Boolean IsA(nint entityClassAddr, String targetClassName)
        {
            var key = entityClassAddr + ":" + targetClassName;
            if (ClassIsSubClass.ContainsKey(key)) return ClassIsSubClass[key];
            var tempEntityClassAddr = entityClassAddr;
            while (true)
            {
                var tempEntity = new UEObject(tempEntityClassAddr);
                var className = tempEntity.GetFullPath();
                if (className == targetClassName)
                {
                    ClassIsSubClass[key] = true;
                    return true;
                }
                tempEntityClassAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(tempEntityClassAddr + structSuperOffset);
                if (tempEntityClassAddr == 0) break;
            }
            ClassIsSubClass[key] = false;
            return false;
        }
        public Boolean IsA(String className)
        {
            return IsA(ClassAddr, className);
        }
        public Boolean IsA<T>(out T converted) where T : UEObject
        {
            var n = typeof(T).Namespace;
            n = n.Substring(3, n.Length - 6).Replace(".", "/");
            n = "Class " + n + "." + typeof(T).Name;
            converted = As<T>();
            return IsA(ClassAddr, n);
        }
        public Boolean IsA<T>() where T : UEObject
        {
            if (Address == 0) return false;
            return IsA<T>(out _);
        }
        public static Boolean NewFName = true;
        public static String GetName(int key)
        {
            var namePtr = UnrealEngine.Memory.ReadProcessMemory<nint>(UnrealEngine.GNames + ((key >> 16) + 2) * 8);
            if (namePtr == 0) return "badIndex";
            var nameEntry = UnrealEngine.Memory.ReadProcessMemory<UInt16>(namePtr + (key & 0xffff) * 2);
            var nameLength = (Int32)(nameEntry >> 6);
            if (nameLength <= 0) return "badIndex";

            UnrealEngine.Memory.maxStringLength = nameLength;
            string result = UnrealEngine.Memory.ReadProcessMemory<String>(namePtr + (key & 0xffff) * 2 + 2);
            UnrealEngine.Memory.maxStringLength = 0x100;
            return result;
        }
        public String GetName()
        {
            return GetName(UnrealEngine.Memory.ReadProcessMemory<int>(Address + nameOffset));
        }
        public String GetShortName()
        {
            if (ClassToName.ContainsKey(ClassAddr)) return ClassToName[ClassAddr];
            var classNameIndex = UnrealEngine.Memory.ReadProcessMemory<int>(ClassAddr + nameOffset);
            ClassToName[ClassAddr] = GetName(classNameIndex);
            return ClassToName[ClassAddr];
        }
        public String GetFullPath()
        {
            if (AddrToName.ContainsKey(Address)) return AddrToName[Address];
            var classPtr = UnrealEngine.Memory.ReadProcessMemory<nint>(Address + classOffset);
            var classNameIndex = UnrealEngine.Memory.ReadProcessMemory<int>(classPtr + nameOffset);
            var name = GetName(classNameIndex);
            var outerEntityAddr = Address;
            var parentName = "";
            while (true)
            {
                var tempOuterEntityAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(outerEntityAddr + objectOuterOffset);
                //var tempOuterEntityAddr = Memory.ReadProcessMemory<UInt64>(outerEntityAddr + structSuperOffset);
                if (tempOuterEntityAddr == outerEntityAddr || tempOuterEntityAddr == 0) break;
                outerEntityAddr = tempOuterEntityAddr;
                var outerNameIndex = UnrealEngine.Memory.ReadProcessMemory<int>(outerEntityAddr + nameOffset);
                var tempName = GetName(outerNameIndex);
                if (tempName == "") break;
                if (tempName == "None") break;
                parentName = tempName + "." + parentName;
            }
            name += " " + parentName;
            var nameIndex = UnrealEngine.Memory.ReadProcessMemory<int>(Address + nameOffset);
            name += GetName(nameIndex);
            AddrToName[Address] = name;
            return name;
        }
        public String GetHierachy()
        {
            var sb = new StringBuilder();
            var tempEntityClassAddr = ClassAddr;
            while (true)
            {
                var tempEntity = new UEObject(tempEntityClassAddr);
                var className = tempEntity.GetFullPath();
                sb.AppendLine(className);
                tempEntityClassAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(tempEntityClassAddr + structSuperOffset);
                if (tempEntityClassAddr == 0) break;
            }
            return sb.ToString();
        }
        public String GetFieldType(nint fieldAddr)
        {
            if (FieldAddrToType.ContainsKey(fieldAddr)) return FieldAddrToType[fieldAddr];
            var fieldType = UnrealEngine.Memory.ReadProcessMemory<nint>(fieldAddr + fieldClassOffset);
            var name = GetName(UnrealEngine.Memory.ReadProcessMemory<int>(fieldType + (NewFName ? 0 : fieldNameOffset)));
            FieldAddrToType[fieldAddr] = name;
            return name;
        }
        nint GetFieldAddr(nint origClassAddr, nint classAddr, string fieldName)
        {
            if (ClassFieldToAddr.ContainsKey(origClassAddr) && ClassFieldToAddr[origClassAddr].ContainsKey(fieldName)) return ClassFieldToAddr[origClassAddr][fieldName];
            var field = classAddr + childPropertiesOffset - fieldNextOffset;
            while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + fieldNextOffset)) > 0)
            {
                var fName = GetName(UnrealEngine.Memory.ReadProcessMemory<int>(field + fieldNameOffset));
                if (fName == fieldName)
                {
                    if (!ClassFieldToAddr.ContainsKey(origClassAddr))
                        ClassFieldToAddr[origClassAddr] = new ConcurrentDictionary<string, nint>();
                    ClassFieldToAddr[origClassAddr][fieldName] = field;
                    return field;
                }
            }
            var parentClass = UnrealEngine.Memory.ReadProcessMemory<nint>(classAddr + structSuperOffset);
            //if (parentClass == classAddr) throw new Exception("parent is me");
            if (parentClass == 0)
            {
                if (!ClassFieldToAddr.ContainsKey(origClassAddr))
                    ClassFieldToAddr[origClassAddr] = new ConcurrentDictionary<string, nint>();
                ClassFieldToAddr[origClassAddr][fieldName] = 0;
                return 0;
            }
            return GetFieldAddr(origClassAddr, parentClass, fieldName);
        }
        public nint GetFieldAddr(string fieldName)
        {
            return GetFieldAddr(ClassAddr, ClassAddr, fieldName);
        }
        public nint GetFuncAddr(nint origClassAddr, nint classAddr, String fieldName)
        {
            if (!NewFName) return GetFieldAddr(origClassAddr, classAddr, fieldName);
            if (ClassFieldToAddr.ContainsKey(origClassAddr) && ClassFieldToAddr[origClassAddr].ContainsKey(fieldName)) return ClassFieldToAddr[origClassAddr][fieldName];
            var field = classAddr + childrenOffset - funcNextOffset;
            while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + funcNextOffset)) > 0)
            {
                var fName = GetName(UnrealEngine.Memory.ReadProcessMemory<int>(field + nameOffset));
                if (fName == fieldName)
                {
                    if (!ClassFieldToAddr.ContainsKey(origClassAddr))
                        ClassFieldToAddr[origClassAddr] = new ConcurrentDictionary<String, nint>();
                    ClassFieldToAddr[origClassAddr][fieldName] = field;
                    return field;
                }
            }
            var parentClass = UnrealEngine.Memory.ReadProcessMemory<nint>(classAddr + structSuperOffset);
            if (parentClass == classAddr) throw new Exception("parent is me");
            if (parentClass == 0) throw new Exception("bad field");
            return GetFuncAddr(origClassAddr, parentClass, fieldName);
        }
        public string GetFuncName(nint origClassAddr, nint classAddr, nint funcAddr)
        {
            var field = classAddr + childrenOffset - funcNextOffset;
            while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + funcNextOffset)) > 0)
            {
                if (funcAddr == field)
                {
                    return GetName(UnrealEngine.Memory.ReadProcessMemory<int>(field + nameOffset));
                }
            }
            var parentClass = UnrealEngine.Memory.ReadProcessMemory<nint>(classAddr + structSuperOffset);
            if (parentClass == classAddr) throw new Exception("parent is me");
            if (parentClass == 0) throw new Exception("bad field");
            return GetFuncName(origClassAddr, parentClass, funcAddr);
        }
        public int FieldOffset;
        public Byte[] Data;
        public nint _value = 0xcafeb00;
        public nint Value
        {
            get
            {
                if (_value != 0xcafeb00) return _value;
                _value = UnrealEngine.Memory.ReadProcessMemory<nint>(Address);
                return _value;
            }
            set
            {
                _value = 0xcafeb00;
                UnrealEngine.Memory.WriteProcessMemory(Address, value);
            }
        }

        public T GetValue<T>()
        {
            return UnrealEngine.Memory.ReadProcessMemory<T>(Address);
        }
        public void SetValue<T>(T value)
        {
            UnrealEngine.Memory.WriteProcessMemory<T>(Address, value);
        }
        UInt64 boolMask = 0;
        public Boolean Flag
        {
            get
            {
                var val = UnrealEngine.Memory.ReadProcessMemory<UInt64>(Address);
                return ((val & boolMask) == boolMask);
            }
            set
            {
                var val = UnrealEngine.Memory.ReadProcessMemory<UInt64>(Address);
                if (value) val |= boolMask;
                else val &= ~boolMask;
                UnrealEngine.Memory.WriteProcessMemory(Address, val);
                //UnrealEngine.Memory.WriteProcessMemory(Address, value);
            }

        }
        public nint Address;
        public UEObject this[String key]
        {
            get
            {
                var fieldAddr = GetFieldAddr(key);
                if (fieldAddr == 0) return null;
                var fieldType = GetFieldType(fieldAddr);
                var offset = GetFieldOffset(fieldAddr);
                UEObject obj;
                if (fieldType == "ObjectProperty" || fieldType == "ScriptStruct")
                    obj = new UEObject(UnrealEngine.Memory.ReadProcessMemory<nint>(Address + offset)) { FieldOffset = offset };
                else if (fieldType == "ArrayProperty")
                {
                    obj = new UEObject(Address + offset);
                    obj._classAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(fieldAddr + fieldClassOffset);
                    var inner = UnrealEngine.Memory.ReadProcessMemory<nint>(fieldAddr + propertySize);
                    var innerClass = UnrealEngine.Memory.ReadProcessMemory<nint>(inner + fieldClassOffset);
                    obj._substructAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(inner + propertySize);
                    //obj._substructAddr;
                }
                else if (fieldType.Contains("Bool"))
                {
                    obj = new UEObject(Address + offset);
                    obj._classAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(fieldAddr + classOffset);
                    obj.boolMask = UnrealEngine.Memory.ReadProcessMemory<Byte>(fieldAddr + propertySize);
                }
                else if (fieldType.Contains("Function"))
                {
                    obj = new UEObject(fieldAddr);
                    //obj.BaseObjAddr = Address;
                }
                else if (fieldType.Contains("StructProperty"))
                {
                    obj = new UEObject(Address + offset);
                    obj._classAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(fieldAddr + propertySize);
                }
                else if (fieldType.Contains("FloatProperty"))
                {
                    obj = new UEObject(Address + offset);
                    obj._classAddr = 0;
                }
                else
                {
                    obj = new UEObject(Address + offset);
                    obj._classAddr = UnrealEngine.Memory.ReadProcessMemory<nint>(fieldAddr + propertySize);
                }
                if (obj.Address == 0)
                {
                    obj = new UEObject(0);
                    //var classInfo = Engine.Instance.DumpClass(ClassAddr);
                    //throw new Exception("bad addr");
                }
                return obj;
            }
            set
            {
                var fieldAddr = GetFieldAddr(key);
                var offset = GetFieldOffset(fieldAddr);
                UnrealEngine.Memory.WriteProcessMemory(Address + offset, value.Address);
            }
        }
        public int _num = int.MaxValue;
        public int Num
        {
            get
            {
                if (_num != int.MaxValue) return _num;
                _num = UnrealEngine.Memory.ReadProcessMemory<int>(Address + 8);
                if (_num > 0x10000) _num = 0x10000;
                return _num;
            }
        }
        public Byte[] _arrayCache = new Byte[0];
        public Byte[] ArrayCache
        {
            get
            {
                if (_arrayCache.Length != 0) return _arrayCache;
                _arrayCache = UnrealEngine.Memory.ReadProcessMemory(Value, Num * 8);
                return _arrayCache;
            }
        }
        public UEObject this[int index] { get { return new UEObject((nint)BitConverter.ToUInt64(ArrayCache, index * 8)); } }
        public nint _vTableFunc = 0xcafeb00;
        public nint VTableFunc
        {
            get
            {
                if (_vTableFunc != 0xcafeb00) return _vTableFunc;
                _vTableFunc = UnrealEngine.Memory.ReadProcessMemory<nint>(Address) + vTableFuncNum * 8;
                _vTableFunc = UnrealEngine.Memory.ReadProcessMemory<nint>(_vTableFunc);
                return _vTableFunc;
            }
        }
        public delegate nint _do(nint baseAddr, nint func, nint args);
        public T Invoke<T>(String funcName, params object[] args)
        {
            var funcAddr = GetFuncAddr(ClassAddr, ClassAddr, funcName);
            var initFlags = UnrealEngine.Memory.ReadProcessMemory<nint>(funcAddr + funcFlagsOffset);
            var nativeFlag = initFlags;
            nativeFlag |= 0x400;
            UnrealEngine.Memory.WriteProcessMemory(funcAddr + funcFlagsOffset, BitConverter.GetBytes(nativeFlag));
            var doActor = Marshal.GetDelegateForFunctionPointer<_do>(VTableFunc);
            var ptr = args.Length == 0 ? (nint)Marshal.AllocHGlobal(0x100) : (nint)args[0]; // todo fix parameter pointer
            var val = doActor(Address, funcAddr, ptr);
            UnrealEngine.Memory.WriteProcessMemory(funcAddr + funcFlagsOffset, BitConverter.GetBytes(initFlags));
            if (default(T) is bool) return (T)(object)((val & 1) == 1);
            else if (default(T) is char) return default(T);
            return default(T);
        }
        public void Invoke(String funcName, params object[] args)
        {
            Invoke<char>(funcName, args);
        }
        public nint _vTableSize = 0;
        public unsafe nint* _vTable;
        public unsafe nint* _vTableOverride;
        public unsafe void PreserveVTable()
        {
            _vTable = (nint*)*(nint*)Address;
            MEMORY_BASIC_INFORMATION64 mbi;
            var i = 0;
            while (VirtualQuery(_vTable[i], out mbi, new UIntPtr((uint)Marshal.SizeOf<MEMORY_BASIC_INFORMATION64>())) != IntPtr.Zero)
            {
                if (mbi.State != 0x1000) break;
                i++;
            }
            _vTableOverride = (nint*)Marshal.AllocHGlobal(8 * i);
            for (var j = 0; j < i; j++) _vTableOverride[j] = _vTable[j];
            _vTableSize = i;
            //return i;
        }
        struct FTextData
        {
            public ulong u1;
            public ulong u2;
            public ulong u3;
            public ulong u4;
            public ulong u5;
            public nint data;
            public int length;
        }
        unsafe struct FText
        {
            public FTextData* data;
            public ulong unk1;
            public ulong unk2;
        }
        public unsafe delegate void pe(nint Class, nint Function, nint Parms);
        static Dictionary<nint, nint> origProcessEvents = new Dictionary<nint, nint> { };
        public unsafe static void Hook(nint Class, nint Function, nint Parms)
        {
            // cache the funcaddr to name...
            var obj = new UEObject((nint)Class);
            var funcName = obj.GetFuncName(obj.ClassAddr, obj.ClassAddr, Function);
            if (ProcessEventContinueHook?.Invoke(obj, funcName, Parms) == true)
                return;
            var doActor = Marshal.GetDelegateForFunctionPointer<pe>(origProcessEvents[(nint)Class]);
            doActor(Class, Function, Parms);
        }
        public static Func<UEObject, string, nint, bool> ProcessEventContinueHook;
        [DllImport("kernel32")] static extern IntPtr OpenThread(uint dwDesiredAccess, bool bInheritHandle, int dwThreadId);
        [DllImport("kernel32")] static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32")] static extern uint ResumeThread(IntPtr hThread);
        [DllImport("kernel32")] static extern uint GetCurrentThreadId();
        public unsafe void HookProcessEvent()
        {
            PreserveVTable();
            delegate*<nint, nint, nint, void> hookPtr = &Hook;
            origProcessEvents[Address] = _vTableOverride[vTableFuncNum];
            _vTableOverride[vTableFuncNum] = (nint)hookPtr;
            var threads = Process.GetCurrentProcess().Threads;
            var suspendedThreads = new List<IntPtr> { };
            var currentThread = GetCurrentThreadId();
            foreach (ProcessThread t in threads)
            {
                var pOpenThread = OpenThread(0x0002, false, t.Id);
                if (pOpenThread == IntPtr.Zero) continue;
                if (currentThread == t.Id) continue;
                suspendedThreads.Add(pOpenThread);
                SuspendThread(pOpenThread);
            }
            *(nint*)Address = (nint)_vTableOverride;
            foreach (var t in suspendedThreads) ResumeThread(t);
        }
        public T As<T>() where T : UEObject
        {
            var obj = (T)Activator.CreateInstance(typeof(T), Address);
            obj._classAddr = _classAddr;
            return obj;
        }
        public string Dump()
        {
            var tempEntity = ClassAddr;
            var fields = new List<object> { };
            while (true)
            {
                var classNameIndex = UnrealEngine.Memory.ReadProcessMemory<int>(tempEntity + nameOffset);
                var name = GetName(classNameIndex);
                var field = tempEntity + childPropertiesOffset - fieldNextOffset;
                while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + fieldNextOffset)) > 0)
                {
                    var fName = GetName(UnrealEngine.Memory.ReadProcessMemory<int>(field + fieldNameOffset));
                    var fType = GetFieldType(field);
                    var fValue = "(" + field.ToString("X") + ")";
                    var offset = GetFieldOffset(field);
                    if (fType == "BoolProperty")
                    {
                        fType = "Boolean";
                        fValue = this[fName].Flag.ToString();
                    }
                    else if (fType == "FloatProperty")
                    {
                        fType = "Single";
                        fValue = BitConverter.ToSingle(BitConverter.GetBytes(this[fName].Value), 0).ToString();
                    }
                    else if (fType == "DoubleProperty")
                    {
                        fType = "Double";
                        fValue = BitConverter.ToDouble(BitConverter.GetBytes(this[fName].Value), 0).ToString();
                    }
                    else if (fType == "IntProperty")
                    {
                        fType = "Int32";
                        fValue = ((int)this[fName].Value).ToString("X");
                    }
                    else if (fType == "ObjectProperty" || fType == "StructProperty")
                    {
                        var structFieldIndex = UnrealEngine.Memory.ReadProcessMemory<int>(UnrealEngine.Memory.ReadProcessMemory<nint>(field + UEObject.propertySize) + UEObject.nameOffset);
                        fType = UEObject.GetName(structFieldIndex);
                    }
                    /*fields.Add(new
                    {
                        info = fType + " " + fName + " = " + fValue
                    });*/
                    fields.Add(fType + " " + fName + " = " + fValue + " ( @ " + offset.ToString("X") + " - " + (this.Address + offset).ToString("X") + " )");
                }

                field = tempEntity + UEObject.childrenOffset - UEObject.funcNextOffset;
                while ((field = UnrealEngine.Memory.ReadProcessMemory<nint>(field + funcNextOffset)) > 0)
                {
                    var fName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<Int32>(field + nameOffset));
                }
                tempEntity = UnrealEngine.Memory.ReadProcessMemory<nint>(tempEntity + structSuperOffset);
                if (tempEntity == 0) break;
            }
            var obj = new
            {
                name = ClassName + " : " + GetFullPath(),
                hierarchy = GetHierachy(),
                fields
            };
            return System.Text.Json.JsonSerializer.Serialize(obj, new System.Text.Json.JsonSerializerOptions { IncludeFields = true, WriteIndented = true });
        }
    }
}