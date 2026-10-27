using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC7 RID: 3527
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFlowMapSVTSample")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UMaterialExpressionFlowMapSVTSample : UMaterialExpressionTextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF47 RID: 48967 RVA: 0x001124A9 File Offset: 0x001106A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFlowMapSVTSample._ClassPtr;
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x001124B8 File Offset: 0x001106B8
		public UMaterialExpressionFlowMapSVTSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFlowMapSVTSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x001124E0 File Offset: 0x001106E0
		public UMaterialExpressionFlowMapSVTSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFlowMapSVTSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x0600BF4A RID: 48970 RVA: 0x00112514 File Offset: 0x00110714
		// (set) Token: 0x0600BF4B RID: 48971 RVA: 0x0011254D File Offset: 0x0011074D
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFlowMapSVTSample.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFlowMapSVTSample.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x00112570 File Offset: 0x00110770
		// (set) Token: 0x0600BF4D RID: 48973 RVA: 0x001125A9 File Offset: 0x001107A9
		public FExpressionInput WorldOrigin
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldOrigin) == null)
				{
					result = (this._WorldOrigin = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFlowMapSVTSample.__PropertyOffset_WorldOrigin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFlowMapSVTSample.__PropertyOffset_WorldOrigin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x0600BF4E RID: 48974 RVA: 0x001125CC File Offset: 0x001107CC
		// (set) Token: 0x0600BF4F RID: 48975 RVA: 0x00112605 File Offset: 0x00110805
		public FExpressionInput WorldSize
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldSize) == null)
				{
					result = (this._WorldSize = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFlowMapSVTSample.__PropertyOffset_WorldSize, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFlowMapSVTSample.__PropertyOffset_WorldSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x00112626 File Offset: 0x00110826
		static UMaterialExpressionFlowMapSVTSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFlowMapSVTSample");
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x00112634 File Offset: 0x00110834
		protected UMaterialExpressionFlowMapSVTSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400653F RID: 25919
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFlowMapSVTSample";

		// Token: 0x04006540 RID: 25920
		private static IntPtr _ClassPtr;

		// Token: 0x04006541 RID: 25921
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006542 RID: 25922
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x04006543 RID: 25923
		[Nullable(2)]
		private FExpressionInput _WorldPosition;

		// Token: 0x04006544 RID: 25924
		internal static int __PropertyOffset_WorldOrigin;

		// Token: 0x04006545 RID: 25925
		[Nullable(2)]
		private FExpressionInput _WorldOrigin;

		// Token: 0x04006546 RID: 25926
		internal static int __PropertyOffset_WorldSize;

		// Token: 0x04006547 RID: 25927
		[Nullable(2)]
		private FExpressionInput _WorldSize;
	}
}
