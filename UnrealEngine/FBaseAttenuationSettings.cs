using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008A2 RID: 2210
	[UnrealObjectPath("/Script/Engine.BaseAttenuationSettings")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FBaseAttenuationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078DD RID: 30941 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBaseAttenuationSettings._ScriptStructPtr != 0) ? FBaseAttenuationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BaseAttenuationSettings", ref FBaseAttenuationSettings._ScriptStructPtr);
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x000AD104 File Offset: 0x000AB304
		// (set) Token: 0x060078DF RID: 30943 RVA: 0x000AD114 File Offset: 0x000AB314
		public unsafe EAttenuationDistanceModel DistanceAlgorithm
		{
			get
			{
				return (EAttenuationDistanceModel)(*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_DistanceAlgorithm));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_DistanceAlgorithm) = (byte)value;
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x000AD125 File Offset: 0x000AB325
		// (set) Token: 0x060078E1 RID: 30945 RVA: 0x000AD139 File Offset: 0x000AB339
		public unsafe TEnumAsByte<EAttenuationShape> AttenuationShape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_AttenuationShape);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_AttenuationShape) = value;
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x000AD14E File Offset: 0x000AB34E
		// (set) Token: 0x060078E3 RID: 30947 RVA: 0x000AD15E File Offset: 0x000AB35E
		public unsafe float dBAttenuationAtMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_dBAttenuationAtMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_dBAttenuationAtMax) = value;
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x060078E4 RID: 30948 RVA: 0x000AD16F File Offset: 0x000AB36F
		// (set) Token: 0x060078E5 RID: 30949 RVA: 0x000AD17F File Offset: 0x000AB37F
		public unsafe ENaturalSoundFalloffMode FalloffMode
		{
			get
			{
				return (ENaturalSoundFalloffMode)(*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_FalloffMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_FalloffMode) = (byte)value;
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x060078E6 RID: 30950 RVA: 0x000AD190 File Offset: 0x000AB390
		// (set) Token: 0x060078E7 RID: 30951 RVA: 0x000AD1A4 File Offset: 0x000AB3A4
		public unsafe FVector AttenuationShapeExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_AttenuationShapeExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_AttenuationShapeExtents) = value;
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x060078E8 RID: 30952 RVA: 0x000AD1B9 File Offset: 0x000AB3B9
		// (set) Token: 0x060078E9 RID: 30953 RVA: 0x000AD1C9 File Offset: 0x000AB3C9
		public unsafe float ConeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_ConeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_ConeOffset) = value;
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x000AD1DA File Offset: 0x000AB3DA
		// (set) Token: 0x060078EB RID: 30955 RVA: 0x000AD1EA File Offset: 0x000AB3EA
		public unsafe float FalloffDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_FalloffDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_FalloffDistance) = value;
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x060078EC RID: 30956 RVA: 0x000AD1FC File Offset: 0x000AB3FC
		// (set) Token: 0x060078ED RID: 30957 RVA: 0x000AD23F File Offset: 0x000AB43F
		[Nullable(1)]
		public FRuntimeFloatCurve CustomAttenuationCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomAttenuationCurve) == null)
				{
					result = (this._CustomAttenuationCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_CustomAttenuationCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FBaseAttenuationSettings.__PropertyOffset_CustomAttenuationCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x000AD260 File Offset: 0x000AB460
		public FBaseAttenuationSettings()
		{
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x000AD268 File Offset: 0x000AB468
		public FBaseAttenuationSettings(EAttenuationDistanceModel DistanceAlgorithm, TEnumAsByte<EAttenuationShape> AttenuationShape, float dBAttenuationAtMax, ENaturalSoundFalloffMode FalloffMode, FVector AttenuationShapeExtents, float ConeOffset, float FalloffDistance, [Nullable(1)] FRuntimeFloatCurve CustomAttenuationCurve)
		{
			this.DistanceAlgorithm = DistanceAlgorithm;
			this.AttenuationShape = AttenuationShape;
			this.dBAttenuationAtMax = dBAttenuationAtMax;
			this.FalloffMode = FalloffMode;
			this.AttenuationShapeExtents = AttenuationShapeExtents;
			this.ConeOffset = ConeOffset;
			this.FalloffDistance = FalloffDistance;
			this.CustomAttenuationCurve = CustomAttenuationCurve;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x000AD2B8 File Offset: 0x000AB4B8
		protected override IntPtr GetUStructPtr()
		{
			return FBaseAttenuationSettings.StaticStruct();
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x000AD2C4 File Offset: 0x000AB4C4
		[NullableContext(2)]
		public FBaseAttenuationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x000AD2CE File Offset: 0x000AB4CE
		public FBaseAttenuationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x000AD2D9 File Offset: 0x000AB4D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBaseAttenuationSettings(Pointer, false, true);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x000AD2E3 File Offset: 0x000AB4E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBaseAttenuationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003A0D RID: 14861
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BaseAttenuationSettings";

		// Token: 0x04003A0E RID: 14862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A0F RID: 14863
		internal static int __PropertyOffset_DistanceAlgorithm;

		// Token: 0x04003A10 RID: 14864
		internal static int __PropertyOffset_AttenuationShape;

		// Token: 0x04003A11 RID: 14865
		internal static int __PropertyOffset_dBAttenuationAtMax;

		// Token: 0x04003A12 RID: 14866
		internal static int __PropertyOffset_FalloffMode;

		// Token: 0x04003A13 RID: 14867
		internal static int __PropertyOffset_AttenuationShapeExtents;

		// Token: 0x04003A14 RID: 14868
		internal static int __PropertyOffset_ConeOffset;

		// Token: 0x04003A15 RID: 14869
		internal static int __PropertyOffset_FalloffDistance;

		// Token: 0x04003A16 RID: 14870
		internal static int __PropertyOffset_CustomAttenuationCurve;

		// Token: 0x04003A17 RID: 14871
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomAttenuationCurve;
	}
}
