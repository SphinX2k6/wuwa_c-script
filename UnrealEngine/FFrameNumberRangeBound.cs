using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000729 RID: 1833
	[UnrealObjectPath("/Script/CoreUObject.FrameNumberRangeBound")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFrameNumberRangeBound : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061E2 RID: 25058 RVA: 0x0008C592 File Offset: 0x0008A792
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameNumberRangeBound._ScriptStructPtr != 0) ? FFrameNumberRangeBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameNumberRangeBound", ref FFrameNumberRangeBound._ScriptStructPtr);
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x0008C5B6 File Offset: 0x0008A7B6
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x0008C5CA File Offset: 0x0008A7CA
		public unsafe TEnumAsByte<ERangeBoundTypes> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x0008C5E0 File Offset: 0x0008A7E0
		// (set) Token: 0x060061E6 RID: 25062 RVA: 0x0008C623 File Offset: 0x0008A823
		[Nullable(1)]
		public FFrameNumber Value
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FFrameNumber(base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x0008C644 File Offset: 0x0008A844
		public FFrameNumberRangeBound()
		{
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x0008C64C File Offset: 0x0008A84C
		public FFrameNumberRangeBound(TEnumAsByte<ERangeBoundTypes> Type, [Nullable(1)] FFrameNumber Value)
		{
			this.Type = Type;
			this.Value = Value;
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x0008C662 File Offset: 0x0008A862
		protected override IntPtr GetUStructPtr()
		{
			return FFrameNumberRangeBound.StaticStruct();
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x0008C66E File Offset: 0x0008A86E
		[NullableContext(2)]
		public FFrameNumberRangeBound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061EB RID: 25067 RVA: 0x0008C678 File Offset: 0x0008A878
		public FFrameNumberRangeBound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x0008C683 File Offset: 0x0008A883
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameNumberRangeBound(Pointer, false, true);
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x0008C68D File Offset: 0x0008A88D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameNumberRangeBound(Pointer, MemoryOwner);
		}

		// Token: 0x04002EBB RID: 11963
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.FrameNumberRangeBound";

		// Token: 0x04002EBC RID: 11964
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002EBD RID: 11965
		internal static int __PropertyOffset_Type;

		// Token: 0x04002EBE RID: 11966
		internal static int __PropertyOffset_Value;

		// Token: 0x04002EBF RID: 11967
		[Nullable(2)]
		private FFrameNumber _Value;
	}
}
