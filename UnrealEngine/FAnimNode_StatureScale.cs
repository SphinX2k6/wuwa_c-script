using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001621 RID: 5665
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_StatureScale")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FAnimNode_StatureScale : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060147AE RID: 83886 RVA: 0x001E201B File Offset: 0x001E021B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_StatureScale._ScriptStructPtr != 0) ? FAnimNode_StatureScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_StatureScale", ref FAnimNode_StatureScale._ScriptStructPtr);
		}

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x060147AF RID: 83887 RVA: 0x001E2040 File Offset: 0x001E0240
		// (set) Token: 0x060147B0 RID: 83888 RVA: 0x001E2083 File Offset: 0x001E0283
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_StatureScale.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_StatureScale.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x060147B1 RID: 83889 RVA: 0x001E20A4 File Offset: 0x001E02A4
		// (set) Token: 0x060147B2 RID: 83890 RVA: 0x001E20E7 File Offset: 0x001E02E7
		public TArray<FStatureConfig> StatureConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStatureConfig> result;
				if ((result = this._StatureConfigs) == null)
				{
					result = (this._StatureConfigs = new TArray<FStatureConfig>(base.NativePtr + (IntPtr)FAnimNode_StatureScale.__PropertyOffset_StatureConfigs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StatureConfigs.CopyAssign(value);
			}
		}

		// Token: 0x060147B3 RID: 83891 RVA: 0x001E20F5 File Offset: 0x001E02F5
		public FAnimNode_StatureScale()
		{
		}

		// Token: 0x060147B4 RID: 83892 RVA: 0x001E20FD File Offset: 0x001E02FD
		public FAnimNode_StatureScale(FPoseLink Base, TArray<FStatureConfig> StatureConfigs)
		{
			this.Base = Base;
			this.StatureConfigs = StatureConfigs;
		}

		// Token: 0x060147B5 RID: 83893 RVA: 0x001E2113 File Offset: 0x001E0313
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_StatureScale.StaticStruct();
		}

		// Token: 0x060147B6 RID: 83894 RVA: 0x001E211F File Offset: 0x001E031F
		[NullableContext(2)]
		public FAnimNode_StatureScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060147B7 RID: 83895 RVA: 0x001E2129 File Offset: 0x001E0329
		public FAnimNode_StatureScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060147B8 RID: 83896 RVA: 0x001E2134 File Offset: 0x001E0334
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_StatureScale(Pointer, false, true);
		}

		// Token: 0x060147B9 RID: 83897 RVA: 0x001E213E File Offset: 0x001E033E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_StatureScale(Pointer, MemoryOwner);
		}

		// Token: 0x0400B23A RID: 45626
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_StatureScale";

		// Token: 0x0400B23B RID: 45627
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B23C RID: 45628
		internal static int __PropertyOffset_Base;

		// Token: 0x0400B23D RID: 45629
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x0400B23E RID: 45630
		internal static int __PropertyOffset_StatureConfigs;

		// Token: 0x0400B23F RID: 45631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStatureConfig> _StatureConfigs;
	}
}
