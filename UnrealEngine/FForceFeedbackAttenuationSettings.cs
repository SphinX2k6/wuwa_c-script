using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BEB RID: 3051
	[UnrealObjectPath("/Script/Engine.ForceFeedbackAttenuationSettings")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FForceFeedbackAttenuationSettings : FBaseAttenuationSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009668 RID: 38504 RVA: 0x000D686D File Offset: 0x000D4A6D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FForceFeedbackAttenuationSettings._ScriptStructPtr != 0) ? FForceFeedbackAttenuationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ForceFeedbackAttenuationSettings", ref FForceFeedbackAttenuationSettings._ScriptStructPtr);
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x000D6891 File Offset: 0x000D4A91
		public FForceFeedbackAttenuationSettings()
		{
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x000D689C File Offset: 0x000D4A9C
		public FForceFeedbackAttenuationSettings(EAttenuationDistanceModel DistanceAlgorithm, TEnumAsByte<EAttenuationShape> AttenuationShape, float dBAttenuationAtMax, ENaturalSoundFalloffMode FalloffMode, FVector AttenuationShapeExtents, float ConeOffset, float FalloffDistance, [Nullable(1)] FRuntimeFloatCurve CustomAttenuationCurve)
		{
			base.DistanceAlgorithm = DistanceAlgorithm;
			base.AttenuationShape = AttenuationShape;
			base.dBAttenuationAtMax = dBAttenuationAtMax;
			base.FalloffMode = FalloffMode;
			base.AttenuationShapeExtents = AttenuationShapeExtents;
			base.ConeOffset = ConeOffset;
			base.FalloffDistance = FalloffDistance;
			base.CustomAttenuationCurve = CustomAttenuationCurve;
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x000D68EC File Offset: 0x000D4AEC
		protected override IntPtr GetUStructPtr()
		{
			return FForceFeedbackAttenuationSettings.StaticStruct();
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x000D68F8 File Offset: 0x000D4AF8
		[NullableContext(2)]
		public FForceFeedbackAttenuationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x000D6902 File Offset: 0x000D4B02
		public FForceFeedbackAttenuationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x000D690D File Offset: 0x000D4B0D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FForceFeedbackAttenuationSettings(Pointer, false, true);
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x000D6917 File Offset: 0x000D4B17
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FForceFeedbackAttenuationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04005463 RID: 21603
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackAttenuationSettings";

		// Token: 0x04005464 RID: 21604
		private static IntPtr _ScriptStructPtr;
	}
}
