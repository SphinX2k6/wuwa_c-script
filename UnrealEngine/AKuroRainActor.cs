using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B94 RID: 7060
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainActor")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class AKuroRainActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ADB2 RID: 110002 RVA: 0x00279AC5 File Offset: 0x00277CC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRainActor._ClassPtr;
		}

		// Token: 0x0601ADB3 RID: 110003 RVA: 0x00279AD4 File Offset: 0x00277CD4
		public AKuroRainActor() : this(BuiltinUtils.AllocNativeUObject(AKuroRainActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ADB4 RID: 110004 RVA: 0x00279AFC File Offset: 0x00277CFC
		[NullableContext(1)]
		public AKuroRainActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRainActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C40 RID: 27712
		// (get) Token: 0x0601ADB5 RID: 110005 RVA: 0x00279B2F File Offset: 0x00277D2F
		// (set) Token: 0x0601ADB6 RID: 110006 RVA: 0x00279B43 File Offset: 0x00277D43
		public unsafe UKuroRainSettings Settings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRainSettings>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRainActor.__PropertyOffset_Settings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRainActor.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x17006C41 RID: 27713
		// (get) Token: 0x0601ADB7 RID: 110007 RVA: 0x00279B58 File Offset: 0x00277D58
		// (set) Token: 0x0601ADB8 RID: 110008 RVA: 0x00279B68 File Offset: 0x00277D68
		public unsafe float BasicGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroRainActor.__PropertyOffset_BasicGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroRainActor.__PropertyOffset_BasicGravity) = value;
			}
		}

		// Token: 0x17006C42 RID: 27714
		// (get) Token: 0x0601ADB9 RID: 110009 RVA: 0x00279B79 File Offset: 0x00277D79
		// (set) Token: 0x0601ADBA RID: 110010 RVA: 0x00279B8D File Offset: 0x00277D8D
		public unsafe UInstancedStaticMeshComponent MeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRainActor.__PropertyOffset_MeshComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRainActor.__PropertyOffset_MeshComp, value);
			}
		}

		// Token: 0x17006C43 RID: 27715
		// (get) Token: 0x0601ADBB RID: 110011 RVA: 0x00279BA2 File Offset: 0x00277DA2
		// (set) Token: 0x0601ADBC RID: 110012 RVA: 0x00279BB6 File Offset: 0x00277DB6
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRainActor.__PropertyOffset_DynamicMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroRainActor.__PropertyOffset_DynamicMaterial, value);
			}
		}

		// Token: 0x17006C44 RID: 27716
		// (get) Token: 0x0601ADBD RID: 110013 RVA: 0x00279BCC File Offset: 0x00277DCC
		// (set) Token: 0x0601ADBE RID: 110014 RVA: 0x00279C05 File Offset: 0x00277E05
		[Nullable(1)]
		public TMap<FName, float> MaterialParameterOverrideFloat
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._MaterialParameterOverrideFloat) == null)
				{
					result = (this._MaterialParameterOverrideFloat = new TMap<FName, float>(base.NativePtr + (IntPtr)AKuroRainActor.__PropertyOffset_MaterialParameterOverrideFloat, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialParameterOverrideFloat.CopyAssign(value);
			}
		}

		// Token: 0x17006C45 RID: 27717
		// (get) Token: 0x0601ADBF RID: 110015 RVA: 0x00279C14 File Offset: 0x00277E14
		// (set) Token: 0x0601ADC0 RID: 110016 RVA: 0x00279C4D File Offset: 0x00277E4D
		[Nullable(1)]
		public TMap<FName, FLinearColor> MaterialParameterOverrideColor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._MaterialParameterOverrideColor) == null)
				{
					result = (this._MaterialParameterOverrideColor = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)AKuroRainActor.__PropertyOffset_MaterialParameterOverrideColor, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialParameterOverrideColor.CopyAssign(value);
			}
		}

		// Token: 0x0601ADC1 RID: 110017 RVA: 0x00279C5B File Offset: 0x00277E5B
		public void Update(float DeltaSeconds)
		{
			AKuroRainActor.__Update_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601ADC2 RID: 110018 RVA: 0x00279C69 File Offset: 0x00277E69
		public void SetupRainConfig()
		{
			AKuroRainActor.__SetupRainConfig_Internal(base.NativePtr);
		}

		// Token: 0x0601ADC3 RID: 110019 RVA: 0x00279C76 File Offset: 0x00277E76
		public void SetMaterialParameterOverrideFloat(FName Name, float Value)
		{
			AKuroRainActor.__SetMaterialParameterOverrideFloat_Internal(base.NativePtr, Name, Value);
		}

		// Token: 0x0601ADC4 RID: 110020 RVA: 0x00279C85 File Offset: 0x00277E85
		public void SetMaterialParameterOverrideColor(FName Name, FLinearColor Value)
		{
			AKuroRainActor.__SetMaterialParameterOverrideColor_Internal(base.NativePtr, Name, Value);
		}

		// Token: 0x0601ADC5 RID: 110021 RVA: 0x00279C94 File Offset: 0x00277E94
		public void SetCurrentRain(float InDensity, float InGravity, float InWindX, float InWindY, float InWindZ)
		{
			AKuroRainActor.__SetCurrentRain_Internal(base.NativePtr, InDensity, InGravity, InWindX, InWindY, InWindZ);
		}

		// Token: 0x0601ADC6 RID: 110022 RVA: 0x00279CA8 File Offset: 0x00277EA8
		public bool GetIsInit()
		{
			return AKuroRainActor.__GetIsInit_Internal(base.NativePtr);
		}

		// Token: 0x0601ADC7 RID: 110023 RVA: 0x00279CB5 File Offset: 0x00277EB5
		public UMaterialInstanceDynamic GetDynamicMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(AKuroRainActor.__GetDynamicMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0601ADC8 RID: 110024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601ADC9 RID: 110025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupRainConfig_Internal(IntPtr @this);

		// Token: 0x0601ADCA RID: 110026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialParameterOverrideFloat_Internal(IntPtr @this, FName Name, float Value);

		// Token: 0x0601ADCB RID: 110027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialParameterOverrideColor_Internal(IntPtr @this, FName Name, FLinearColor Value);

		// Token: 0x0601ADCC RID: 110028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentRain_Internal(IntPtr @this, float InDensity, float InGravity, float InWindX, float InWindY, float InWindZ);

		// Token: 0x0601ADCD RID: 110029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsInit_Internal(IntPtr @this);

		// Token: 0x0601ADCE RID: 110030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicMaterial_Internal(IntPtr @this);

		// Token: 0x0601ADCF RID: 110031 RVA: 0x00279CC7 File Offset: 0x00277EC7
		static AKuroRainActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRainActor");
		}

		// Token: 0x0601ADD0 RID: 110032 RVA: 0x00279CD5 File Offset: 0x00277ED5
		protected AKuroRainActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8A1 RID: 59553
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainActor";

		// Token: 0x0400E8A2 RID: 59554
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8A3 RID: 59555
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E8A4 RID: 59556
		internal static int __PropertyOffset_Settings;

		// Token: 0x0400E8A5 RID: 59557
		internal static int __PropertyOffset_BasicGravity;

		// Token: 0x0400E8A6 RID: 59558
		internal static int __PropertyOffset_MeshComp;

		// Token: 0x0400E8A7 RID: 59559
		internal static int __PropertyOffset_DynamicMaterial;

		// Token: 0x0400E8A8 RID: 59560
		internal static int __PropertyOffset_MaterialParameterOverrideFloat;

		// Token: 0x0400E8A9 RID: 59561
		private TMap<FName, float> _MaterialParameterOverrideFloat;

		// Token: 0x0400E8AA RID: 59562
		internal static int __PropertyOffset_MaterialParameterOverrideColor;

		// Token: 0x0400E8AB RID: 59563
		private TMap<FName, FLinearColor> _MaterialParameterOverrideColor;
	}
}
