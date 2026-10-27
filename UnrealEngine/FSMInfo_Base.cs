using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002886 RID: 10374
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMInfo_Base")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FSMInfo_Base : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602664F RID: 157263 RVA: 0x003A5A80 File Offset: 0x003A3C80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMInfo_Base._ScriptStructPtr != 0) ? FSMInfo_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMInfo_Base", ref FSMInfo_Base._ScriptStructPtr);
		}

		// Token: 0x1700940F RID: 37903
		// (get) Token: 0x06026650 RID: 157264 RVA: 0x003A5AA4 File Offset: 0x003A3CA4
		// (set) Token: 0x06026651 RID: 157265 RVA: 0x003A5AB8 File Offset: 0x003A3CB8
		public unsafe string NodeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSMInfo_Base.__PropertyOffset_NodeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSMInfo_Base.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x17009410 RID: 37904
		// (get) Token: 0x06026652 RID: 157266 RVA: 0x003A5ACD File Offset: 0x003A3CCD
		// (set) Token: 0x06026653 RID: 157267 RVA: 0x003A5AE1 File Offset: 0x003A3CE1
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17009411 RID: 37905
		// (get) Token: 0x06026654 RID: 157268 RVA: 0x003A5AF6 File Offset: 0x003A3CF6
		// (set) Token: 0x06026655 RID: 157269 RVA: 0x003A5B0A File Offset: 0x003A3D0A
		public unsafe FGuid OwnerGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_OwnerGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_OwnerGuid) = value;
			}
		}

		// Token: 0x17009412 RID: 37906
		// (get) Token: 0x06026656 RID: 157270 RVA: 0x003A5B1F File Offset: 0x003A3D1F
		// (set) Token: 0x06026657 RID: 157271 RVA: 0x003A5B33 File Offset: 0x003A3D33
		public unsafe FGuid NodeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_NodeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_NodeGuid) = value;
			}
		}

		// Token: 0x17009413 RID: 37907
		// (get) Token: 0x06026658 RID: 157272 RVA: 0x003A5B48 File Offset: 0x003A3D48
		// (set) Token: 0x06026659 RID: 157273 RVA: 0x003A5B5C File Offset: 0x003A3D5C
		public unsafe FGuid OwnerNodeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_OwnerNodeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMInfo_Base.__PropertyOffset_OwnerNodeGuid) = value;
			}
		}

		// Token: 0x17009414 RID: 37908
		// (get) Token: 0x0602665A RID: 157274 RVA: 0x003A5B71 File Offset: 0x003A3D71
		// (set) Token: 0x0602665B RID: 157275 RVA: 0x003A5B85 File Offset: 0x003A3D85
		[Nullable(2)]
		public unsafe USMNodeInstance NodeInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMNodeInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FSMInfo_Base.__PropertyOffset_NodeInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMInfo_Base.__PropertyOffset_NodeInstance, value);
			}
		}

		// Token: 0x0602665C RID: 157276 RVA: 0x003A5B9A File Offset: 0x003A3D9A
		public FSMInfo_Base()
		{
		}

		// Token: 0x0602665D RID: 157277 RVA: 0x003A5BA2 File Offset: 0x003A3DA2
		public FSMInfo_Base(string NodeName, FGuid Guid, FGuid OwnerGuid, FGuid NodeGuid, FGuid OwnerNodeGuid, USMNodeInstance NodeInstance)
		{
			this.NodeName = NodeName;
			this.Guid = Guid;
			this.OwnerGuid = OwnerGuid;
			this.NodeGuid = NodeGuid;
			this.OwnerNodeGuid = OwnerNodeGuid;
			this.NodeInstance = NodeInstance;
		}

		// Token: 0x0602665E RID: 157278 RVA: 0x003A5BD7 File Offset: 0x003A3DD7
		protected override IntPtr GetUStructPtr()
		{
			return FSMInfo_Base.StaticStruct();
		}

		// Token: 0x0602665F RID: 157279 RVA: 0x003A5BE3 File Offset: 0x003A3DE3
		[NullableContext(2)]
		public FSMInfo_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026660 RID: 157280 RVA: 0x003A5BED File Offset: 0x003A3DED
		public FSMInfo_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026661 RID: 157281 RVA: 0x003A5BF8 File Offset: 0x003A3DF8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMInfo_Base(Pointer, false, true);
		}

		// Token: 0x06026662 RID: 157282 RVA: 0x003A5C02 File Offset: 0x003A3E02
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMInfo_Base(Pointer, MemoryOwner);
		}

		// Token: 0x040150E7 RID: 86247
		public const string __ObjectPath = "/Script/SMSystem.SMInfo_Base";

		// Token: 0x040150E8 RID: 86248
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150E9 RID: 86249
		internal static int __PropertyOffset_NodeName;

		// Token: 0x040150EA RID: 86250
		internal static int __PropertyOffset_Guid;

		// Token: 0x040150EB RID: 86251
		internal static int __PropertyOffset_OwnerGuid;

		// Token: 0x040150EC RID: 86252
		internal static int __PropertyOffset_NodeGuid;

		// Token: 0x040150ED RID: 86253
		internal static int __PropertyOffset_OwnerNodeGuid;

		// Token: 0x040150EE RID: 86254
		internal static int __PropertyOffset_NodeInstance;
	}
}
