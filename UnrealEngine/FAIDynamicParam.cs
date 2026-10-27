using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000ED RID: 237
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIDynamicParam")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAIDynamicParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012B5 RID: 4789 RVA: 0x0001BB69 File Offset: 0x00019D69
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDynamicParam._ScriptStructPtr != 0) ? FAIDynamicParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDynamicParam", ref FAIDynamicParam._ScriptStructPtr);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0001BB8D File Offset: 0x00019D8D
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0001BBA1 File Offset: 0x00019DA1
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0001BBB6 File Offset: 0x00019DB6
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0001BBC6 File Offset: 0x00019DC6
		public unsafe EAIParamType ParamType
		{
			get
			{
				return (EAIParamType)(*(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_ParamType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_ParamType) = (byte)value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0001BBD7 File Offset: 0x00019DD7
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x0001BBE7 File Offset: 0x00019DE7
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0001BBF8 File Offset: 0x00019DF8
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0001BC3B File Offset: 0x00019E3B
		public FBlackboardKeySelector BBKey
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BBKey) == null)
				{
					result = (this._BBKey = new FBlackboardKeySelector(base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_BBKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)FAIDynamicParam.__PropertyOffset_BBKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0001BC5C File Offset: 0x00019E5C
		public FAIDynamicParam()
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0001BC64 File Offset: 0x00019E64
		public FAIDynamicParam(FName ParamName, EAIParamType ParamType, float Value, FBlackboardKeySelector BBKey)
		{
			this.ParamName = ParamName;
			this.ParamType = ParamType;
			this.Value = Value;
			this.BBKey = BBKey;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0001BC89 File Offset: 0x00019E89
		protected override IntPtr GetUStructPtr()
		{
			return FAIDynamicParam.StaticStruct();
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0001BC95 File Offset: 0x00019E95
		[NullableContext(2)]
		public FAIDynamicParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0001BC9F File Offset: 0x00019E9F
		public FAIDynamicParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0001BCAA File Offset: 0x00019EAA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDynamicParam(Pointer, false, true);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0001BCB4 File Offset: 0x00019EB4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDynamicParam(Pointer, MemoryOwner);
		}

		// Token: 0x04000343 RID: 835
		public const string __ObjectPath = "/Script/AIModule.AIDynamicParam";

		// Token: 0x04000344 RID: 836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000345 RID: 837
		internal static int __PropertyOffset_ParamName;

		// Token: 0x04000346 RID: 838
		internal static int __PropertyOffset_ParamType;

		// Token: 0x04000347 RID: 839
		internal static int __PropertyOffset_Value;

		// Token: 0x04000348 RID: 840
		internal static int __PropertyOffset_BBKey;

		// Token: 0x04000349 RID: 841
		[Nullable(2)]
		private FBlackboardKeySelector _BBKey;
	}
}
