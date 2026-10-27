using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE4 RID: 7140
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherController")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class AKuroWeatherController : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B729 RID: 112425 RVA: 0x00286CB0 File Offset: 0x00284EB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWeatherController._ClassPtr;
		}

		// Token: 0x0601B72A RID: 112426 RVA: 0x00286CBC File Offset: 0x00284EBC
		public AKuroWeatherController() : this(BuiltinUtils.AllocNativeUObject(AKuroWeatherController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B72B RID: 112427 RVA: 0x00286CE4 File Offset: 0x00284EE4
		[NullableContext(1)]
		public AKuroWeatherController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWeatherController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E61 RID: 28257
		// (get) Token: 0x0601B72C RID: 112428 RVA: 0x00286D17 File Offset: 0x00284F17
		// (set) Token: 0x0601B72D RID: 112429 RVA: 0x00286D2B File Offset: 0x00284F2B
		[Nullable(2)]
		public unsafe AKuroGlobalGI GlobalGI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroGlobalGI>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeatherController.__PropertyOffset_GlobalGI);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroWeatherController.__PropertyOffset_GlobalGI, value);
			}
		}

		// Token: 0x17006E62 RID: 28258
		// (get) Token: 0x0601B72E RID: 112430 RVA: 0x00286D40 File Offset: 0x00284F40
		// (set) Token: 0x0601B72F RID: 112431 RVA: 0x00286D50 File Offset: 0x00284F50
		public unsafe float RainIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_RainIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_RainIntensity) = value;
			}
		}

		// Token: 0x17006E63 RID: 28259
		// (get) Token: 0x0601B730 RID: 112432 RVA: 0x00286D61 File Offset: 0x00284F61
		// (set) Token: 0x0601B731 RID: 112433 RVA: 0x00286D71 File Offset: 0x00284F71
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17006E64 RID: 28260
		// (get) Token: 0x0601B732 RID: 112434 RVA: 0x00286D82 File Offset: 0x00284F82
		// (set) Token: 0x0601B733 RID: 112435 RVA: 0x00286D96 File Offset: 0x00284F96
		public unsafe FVectorDouble PostCharacterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_PostCharacterPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_PostCharacterPos) = value;
			}
		}

		// Token: 0x17006E65 RID: 28261
		// (get) Token: 0x0601B734 RID: 112436 RVA: 0x00286DAB File Offset: 0x00284FAB
		// (set) Token: 0x0601B735 RID: 112437 RVA: 0x00286DBB File Offset: 0x00284FBB
		public unsafe bool bIsInCave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_bIsInCave) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWeatherController.__PropertyOffset_bIsInCave) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601B736 RID: 112438 RVA: 0x00286DCC File Offset: 0x00284FCC
		public void TracingCave()
		{
			AKuroWeatherController.__TracingCave_Internal(base.NativePtr);
		}

		// Token: 0x0601B737 RID: 112439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TracingCave_Internal(IntPtr @this);

		// Token: 0x0601B738 RID: 112440 RVA: 0x00286DD9 File Offset: 0x00284FD9
		static AKuroWeatherController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherController");
		}

		// Token: 0x0601B739 RID: 112441 RVA: 0x00286DE7 File Offset: 0x00284FE7
		protected AKuroWeatherController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC4F RID: 60495
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWeatherController";

		// Token: 0x0400EC50 RID: 60496
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC51 RID: 60497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC52 RID: 60498
		internal static int __PropertyOffset_GlobalGI;

		// Token: 0x0400EC53 RID: 60499
		internal static int __PropertyOffset_RainIntensity;

		// Token: 0x0400EC54 RID: 60500
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400EC55 RID: 60501
		internal static int __PropertyOffset_PostCharacterPos;

		// Token: 0x0400EC56 RID: 60502
		internal static int __PropertyOffset_bIsInCave;
	}
}
