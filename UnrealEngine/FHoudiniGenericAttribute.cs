using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014C1 RID: 5313
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniGenericAttribute")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FHoudiniGenericAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601339C RID: 78748 RVA: 0x001C4659 File Offset: 0x001C2859
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniGenericAttribute._ScriptStructPtr != 0) ? FHoudiniGenericAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniGenericAttribute", ref FHoudiniGenericAttribute._ScriptStructPtr);
		}

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x0601339D RID: 78749 RVA: 0x001C467D File Offset: 0x001C287D
		// (set) Token: 0x0601339E RID: 78750 RVA: 0x001C4691 File Offset: 0x001C2891
		public unsafe string AttributeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeName)), value);
			}
		}

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x0601339F RID: 78751 RVA: 0x001C46A6 File Offset: 0x001C28A6
		// (set) Token: 0x060133A0 RID: 78752 RVA: 0x001C46B6 File Offset: 0x001C28B6
		public unsafe EAttribStorageType AttributeType
		{
			get
			{
				return (EAttribStorageType)(*(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeType) = (byte)value;
			}
		}

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x060133A1 RID: 78753 RVA: 0x001C46C7 File Offset: 0x001C28C7
		// (set) Token: 0x060133A2 RID: 78754 RVA: 0x001C46D7 File Offset: 0x001C28D7
		public unsafe EAttribOwner AttributeOwner
		{
			get
			{
				return (EAttribOwner)(*(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeOwner));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeOwner) = (byte)value;
			}
		}

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x060133A3 RID: 78755 RVA: 0x001C46E8 File Offset: 0x001C28E8
		// (set) Token: 0x060133A4 RID: 78756 RVA: 0x001C46F8 File Offset: 0x001C28F8
		public unsafe int AttributeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeCount) = value;
			}
		}

		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x060133A5 RID: 78757 RVA: 0x001C4709 File Offset: 0x001C2909
		// (set) Token: 0x060133A6 RID: 78758 RVA: 0x001C4719 File Offset: 0x001C2919
		public unsafe int AttributeTupleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeTupleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_AttributeTupleSize) = value;
			}
		}

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x060133A7 RID: 78759 RVA: 0x001C472C File Offset: 0x001C292C
		// (set) Token: 0x060133A8 RID: 78760 RVA: 0x001C476F File Offset: 0x001C296F
		public TArray<double> DoubleValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<double> result;
				if ((result = this._DoubleValues) == null)
				{
					result = (this._DoubleValues = new TArray<double>(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_DoubleValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DoubleValues.CopyAssign(value);
			}
		}

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x060133A9 RID: 78761 RVA: 0x001C4780 File Offset: 0x001C2980
		// (set) Token: 0x060133AA RID: 78762 RVA: 0x001C47C3 File Offset: 0x001C29C3
		public TArray<long> IntValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._IntValues) == null)
				{
					result = (this._IntValues = new TArray<long>(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_IntValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntValues.CopyAssign(value);
			}
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x060133AB RID: 78763 RVA: 0x001C47D4 File Offset: 0x001C29D4
		// (set) Token: 0x060133AC RID: 78764 RVA: 0x001C4817 File Offset: 0x001C2A17
		public TArray<string> StringValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StringValues) == null)
				{
					result = (this._StringValues = new TArray<string>(base.NativePtr + (IntPtr)FHoudiniGenericAttribute.__PropertyOffset_StringValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringValues.CopyAssign(value);
			}
		}

		// Token: 0x060133AD RID: 78765 RVA: 0x001C4825 File Offset: 0x001C2A25
		public FHoudiniGenericAttribute()
		{
		}

		// Token: 0x060133AE RID: 78766 RVA: 0x001C4830 File Offset: 0x001C2A30
		public FHoudiniGenericAttribute(string AttributeName, EAttribStorageType AttributeType, EAttribOwner AttributeOwner, int AttributeCount, int AttributeTupleSize, TArray<double> DoubleValues, TArray<long> IntValues, TArray<string> StringValues)
		{
			this.AttributeName = AttributeName;
			this.AttributeType = AttributeType;
			this.AttributeOwner = AttributeOwner;
			this.AttributeCount = AttributeCount;
			this.AttributeTupleSize = AttributeTupleSize;
			this.DoubleValues = DoubleValues;
			this.IntValues = IntValues;
			this.StringValues = StringValues;
		}

		// Token: 0x060133AF RID: 78767 RVA: 0x001C4880 File Offset: 0x001C2A80
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniGenericAttribute.StaticStruct();
		}

		// Token: 0x060133B0 RID: 78768 RVA: 0x001C488C File Offset: 0x001C2A8C
		[NullableContext(2)]
		public FHoudiniGenericAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060133B1 RID: 78769 RVA: 0x001C4896 File Offset: 0x001C2A96
		public FHoudiniGenericAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060133B2 RID: 78770 RVA: 0x001C48A1 File Offset: 0x001C2AA1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniGenericAttribute(Pointer, false, true);
		}

		// Token: 0x060133B3 RID: 78771 RVA: 0x001C48AB File Offset: 0x001C2AAB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniGenericAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x0400A61A RID: 42522
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniGenericAttribute";

		// Token: 0x0400A61B RID: 42523
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A61C RID: 42524
		internal static int __PropertyOffset_AttributeName;

		// Token: 0x0400A61D RID: 42525
		internal static int __PropertyOffset_AttributeType;

		// Token: 0x0400A61E RID: 42526
		internal static int __PropertyOffset_AttributeOwner;

		// Token: 0x0400A61F RID: 42527
		internal static int __PropertyOffset_AttributeCount;

		// Token: 0x0400A620 RID: 42528
		internal static int __PropertyOffset_AttributeTupleSize;

		// Token: 0x0400A621 RID: 42529
		internal static int __PropertyOffset_DoubleValues;

		// Token: 0x0400A622 RID: 42530
		[Nullable(2)]
		private TArray<double> _DoubleValues;

		// Token: 0x0400A623 RID: 42531
		internal static int __PropertyOffset_IntValues;

		// Token: 0x0400A624 RID: 42532
		[Nullable(2)]
		private TArray<long> _IntValues;

		// Token: 0x0400A625 RID: 42533
		internal static int __PropertyOffset_StringValues;

		// Token: 0x0400A626 RID: 42534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringValues;
	}
}
