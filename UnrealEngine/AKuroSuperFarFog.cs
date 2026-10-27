using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BCC RID: 7116
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFog")]
	[UnrealStructLayout(1640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1640)]
	public class AKuroSuperFarFog : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B4E8 RID: 111848 RVA: 0x00283BCB File Offset: 0x00281DCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSuperFarFog._ClassPtr;
		}

		// Token: 0x0601B4E9 RID: 111849 RVA: 0x00283BD8 File Offset: 0x00281DD8
		public AKuroSuperFarFog() : this(BuiltinUtils.AllocNativeUObject(AKuroSuperFarFog.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B4EA RID: 111850 RVA: 0x00283C00 File Offset: 0x00281E00
		[NullableContext(1)]
		public AKuroSuperFarFog(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSuperFarFog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DB4 RID: 28084
		// (get) Token: 0x0601B4EB RID: 111851 RVA: 0x00283C33 File Offset: 0x00281E33
		// (set) Token: 0x0601B4EC RID: 111852 RVA: 0x00283C47 File Offset: 0x00281E47
		public unsafe UStaticMeshComponent FogMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSuperFarFog.__PropertyOffset_FogMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSuperFarFog.__PropertyOffset_FogMeshComponent, value);
			}
		}

		// Token: 0x17006DB5 RID: 28085
		// (get) Token: 0x0601B4ED RID: 111853 RVA: 0x00283C5C File Offset: 0x00281E5C
		// (set) Token: 0x0601B4EE RID: 111854 RVA: 0x00283C70 File Offset: 0x00281E70
		public unsafe UKuroSuperFarFogConfig Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSuperFarFogConfig>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSuperFarFog.__PropertyOffset_Config);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroSuperFarFog.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x17006DB6 RID: 28086
		// (get) Token: 0x0601B4EF RID: 111855 RVA: 0x00283C85 File Offset: 0x00281E85
		// (set) Token: 0x0601B4F0 RID: 111856 RVA: 0x00283C95 File Offset: 0x00281E95
		public unsafe bool bUseDayNightMixColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_bUseDayNightMixColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_bUseDayNightMixColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DB7 RID: 28087
		// (get) Token: 0x0601B4F1 RID: 111857 RVA: 0x00283CA6 File Offset: 0x00281EA6
		// (set) Token: 0x0601B4F2 RID: 111858 RVA: 0x00283CBA File Offset: 0x00281EBA
		public unsafe FLinearColor ColorTintDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_ColorTintDay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_ColorTintDay) = value;
			}
		}

		// Token: 0x17006DB8 RID: 28088
		// (get) Token: 0x0601B4F3 RID: 111859 RVA: 0x00283CCF File Offset: 0x00281ECF
		// (set) Token: 0x0601B4F4 RID: 111860 RVA: 0x00283CE3 File Offset: 0x00281EE3
		public unsafe FLinearColor ColorTintNight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_ColorTintNight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_ColorTintNight) = value;
			}
		}

		// Token: 0x17006DB9 RID: 28089
		// (get) Token: 0x0601B4F5 RID: 111861 RVA: 0x00283CF8 File Offset: 0x00281EF8
		// (set) Token: 0x0601B4F6 RID: 111862 RVA: 0x00283D31 File Offset: 0x00281F31
		[Nullable(1)]
		public FKuroCurveFloat DayNightMixCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DayNightMixCurve) == null)
				{
					result = (this._DayNightMixCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_DayNightMixCurve, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)AKuroSuperFarFog.__PropertyOffset_DayNightMixCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601B4F7 RID: 111863 RVA: 0x00283D52 File Offset: 0x00281F52
		public void UpdateFog()
		{
			AKuroSuperFarFog.__UpdateFog_Internal(base.NativePtr);
		}

		// Token: 0x0601B4F8 RID: 111864 RVA: 0x00283D5F File Offset: 0x00281F5F
		public virtual void Update(float DeltaSeconds)
		{
			AKuroSuperFarFog.__Update_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601B4F9 RID: 111865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateFog_Internal(IntPtr @this);

		// Token: 0x0601B4FA RID: 111866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601B4FB RID: 111867 RVA: 0x00283D6D File Offset: 0x00281F6D
		static AKuroSuperFarFog()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFog");
		}

		// Token: 0x0601B4FC RID: 111868 RVA: 0x00283D7B File Offset: 0x00281F7B
		protected AKuroSuperFarFog(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB42 RID: 60226
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFog";

		// Token: 0x0400EB43 RID: 60227
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB44 RID: 60228
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB45 RID: 60229
		internal static int __PropertyOffset_FogMeshComponent;

		// Token: 0x0400EB46 RID: 60230
		internal static int __PropertyOffset_Config;

		// Token: 0x0400EB47 RID: 60231
		internal static int __PropertyOffset_bUseDayNightMixColor;

		// Token: 0x0400EB48 RID: 60232
		internal static int __PropertyOffset_ColorTintDay;

		// Token: 0x0400EB49 RID: 60233
		internal static int __PropertyOffset_ColorTintNight;

		// Token: 0x0400EB4A RID: 60234
		internal static int __PropertyOffset_DayNightMixCurve;

		// Token: 0x0400EB4B RID: 60235
		private FKuroCurveFloat _DayNightMixCurve;

		// Token: 0x0200317D RID: 12669
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04016FB7 RID: 94135
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
