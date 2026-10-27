using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E9 RID: 745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ModifyCurve")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FAnimNode_ModifyCurve : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A5D RID: 10845 RVA: 0x0004051C File Offset: 0x0003E71C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ModifyCurve._ScriptStructPtr != 0) ? FAnimNode_ModifyCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ModifyCurve", ref FAnimNode_ModifyCurve._ScriptStructPtr);
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00040540 File Offset: 0x0003E740
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x00040583 File Offset: 0x0003E783
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000405A4 File Offset: 0x0003E7A4
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x000405E7 File Offset: 0x0003E7E7
		public TArray<float> CurveValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CurveValues) == null)
				{
					result = (this._CurveValues = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_CurveValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveValues.CopyAssign(value);
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x000405F8 File Offset: 0x0003E7F8
		// (set) Token: 0x06002A63 RID: 10851 RVA: 0x0004063B File Offset: 0x0003E83B
		public TArray<FName> CurveNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CurveNames) == null)
				{
					result = (this._CurveNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_CurveNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveNames.CopyAssign(value);
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x00040649 File Offset: 0x0003E849
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x00040659 File Offset: 0x0003E859
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x0004066A File Offset: 0x0003E86A
		// (set) Token: 0x06002A67 RID: 10855 RVA: 0x0004067A File Offset: 0x0003E87A
		public unsafe EModifyCurveApplyMode ApplyMode
		{
			get
			{
				return (EModifyCurveApplyMode)(*(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_ApplyMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyCurve.__PropertyOffset_ApplyMode) = (byte)value;
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0004068B File Offset: 0x0003E88B
		public FAnimNode_ModifyCurve()
		{
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00040693 File Offset: 0x0003E893
		public FAnimNode_ModifyCurve(FPoseLink SourcePose, TArray<float> CurveValues, TArray<FName> CurveNames, float Alpha, EModifyCurveApplyMode ApplyMode)
		{
			this.SourcePose = SourcePose;
			this.CurveValues = CurveValues;
			this.CurveNames = CurveNames;
			this.Alpha = Alpha;
			this.ApplyMode = ApplyMode;
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000406C0 File Offset: 0x0003E8C0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ModifyCurve.StaticStruct();
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000406CC File Offset: 0x0003E8CC
		[NullableContext(2)]
		public FAnimNode_ModifyCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000406D6 File Offset: 0x0003E8D6
		public FAnimNode_ModifyCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000406E1 File Offset: 0x0003E8E1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ModifyCurve(Pointer, false, true);
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000406EB File Offset: 0x0003E8EB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ModifyCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04001121 RID: 4385
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ModifyCurve";

		// Token: 0x04001122 RID: 4386
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001123 RID: 4387
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x04001124 RID: 4388
		[Nullable(2)]
		private FPoseLink _SourcePose;

		// Token: 0x04001125 RID: 4389
		internal static int __PropertyOffset_CurveValues;

		// Token: 0x04001126 RID: 4390
		[Nullable(2)]
		private TArray<float> _CurveValues;

		// Token: 0x04001127 RID: 4391
		internal static int __PropertyOffset_CurveNames;

		// Token: 0x04001128 RID: 4392
		[Nullable(2)]
		private TArray<FName> _CurveNames;

		// Token: 0x04001129 RID: 4393
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400112A RID: 4394
		internal static int __PropertyOffset_ApplyMode;
	}
}
