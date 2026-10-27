using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B1D RID: 6941
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHaloComponent")]
	[UnrealStructLayout(2064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class UKuroHaloComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A1D1 RID: 106961 RVA: 0x00268A9A File Offset: 0x00266C9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHaloComponent._ClassPtr;
		}

		// Token: 0x0601A1D2 RID: 106962 RVA: 0x00268AA8 File Offset: 0x00266CA8
		public UKuroHaloComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroHaloComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A1D3 RID: 106963 RVA: 0x00268AD0 File Offset: 0x00266CD0
		public UKuroHaloComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHaloComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170068D9 RID: 26841
		// (get) Token: 0x0601A1D4 RID: 106964 RVA: 0x00268B04 File Offset: 0x00266D04
		// (set) Token: 0x0601A1D5 RID: 106965 RVA: 0x00268B3D File Offset: 0x00266D3D
		public FParameterChanged OnParameterChangedEvent
		{
			get
			{
				base.FastCheckIsValid();
				FParameterChanged result;
				if ((result = this._OnParameterChangedEvent) == null)
				{
					result = (this._OnParameterChangedEvent = new FParameterChanged(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_OnParameterChangedEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_OnParameterChangedEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170068DA RID: 26842
		// (get) Token: 0x0601A1D6 RID: 106966 RVA: 0x00268B5E File Offset: 0x00266D5E
		// (set) Token: 0x0601A1D7 RID: 106967 RVA: 0x00268B6E File Offset: 0x00266D6E
		public unsafe float HaloMinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMinDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMinDrawDistance) = value;
			}
		}

		// Token: 0x170068DB RID: 26843
		// (get) Token: 0x0601A1D8 RID: 106968 RVA: 0x00268B7F File Offset: 0x00266D7F
		// (set) Token: 0x0601A1D9 RID: 106969 RVA: 0x00268B8F File Offset: 0x00266D8F
		public unsafe float HaloMaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMaxDrawDistance) = value;
			}
		}

		// Token: 0x170068DC RID: 26844
		// (get) Token: 0x0601A1DA RID: 106970 RVA: 0x00268BA0 File Offset: 0x00266DA0
		// (set) Token: 0x0601A1DB RID: 106971 RVA: 0x00268BB0 File Offset: 0x00266DB0
		public unsafe float HaloMinDrawFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMinDrawFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMinDrawFadeRange) = value;
			}
		}

		// Token: 0x170068DD RID: 26845
		// (get) Token: 0x0601A1DC RID: 106972 RVA: 0x00268BC1 File Offset: 0x00266DC1
		// (set) Token: 0x0601A1DD RID: 106973 RVA: 0x00268BD1 File Offset: 0x00266DD1
		public unsafe float HaloMaxDrawFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMaxDrawFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_HaloMaxDrawFadeRange) = value;
			}
		}

		// Token: 0x170068DE RID: 26846
		// (get) Token: 0x0601A1DE RID: 106974 RVA: 0x00268BE2 File Offset: 0x00266DE2
		// (set) Token: 0x0601A1DF RID: 106975 RVA: 0x00268BF2 File Offset: 0x00266DF2
		public unsafe float LightRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_LightRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_LightRadius) = value;
			}
		}

		// Token: 0x170068DF RID: 26847
		// (get) Token: 0x0601A1E0 RID: 106976 RVA: 0x00268C03 File Offset: 0x00266E03
		// (set) Token: 0x0601A1E1 RID: 106977 RVA: 0x00268C13 File Offset: 0x00266E13
		public unsafe float BoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_BoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHaloComponent.__PropertyOffset_BoxExtent) = value;
			}
		}

		// Token: 0x0601A1E2 RID: 106978 RVA: 0x00268C24 File Offset: 0x00266E24
		public void SetRadius(float Radius)
		{
			UKuroHaloComponent.__SetRadius_Internal(base.NativePtr, Radius);
		}

		// Token: 0x0601A1E3 RID: 106979 RVA: 0x00268C32 File Offset: 0x00266E32
		public float GetLightRadius()
		{
			return UKuroHaloComponent.__GetLightRadius_Internal(base.NativePtr);
		}

		// Token: 0x0601A1E4 RID: 106980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadius_Internal(IntPtr @this, float Radius);

		// Token: 0x0601A1E5 RID: 106981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLightRadius_Internal(IntPtr @this);

		// Token: 0x0601A1E6 RID: 106982 RVA: 0x00268C3F File Offset: 0x00266E3F
		static UKuroHaloComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHaloComponent");
		}

		// Token: 0x0601A1E7 RID: 106983 RVA: 0x00268C4D File Offset: 0x00266E4D
		protected UKuroHaloComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2E1 RID: 58081
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHaloComponent";

		// Token: 0x0400E2E2 RID: 58082
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2E3 RID: 58083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E2E4 RID: 58084
		internal static int __PropertyOffset_OnParameterChangedEvent;

		// Token: 0x0400E2E5 RID: 58085
		[Nullable(2)]
		private FParameterChanged _OnParameterChangedEvent;

		// Token: 0x0400E2E6 RID: 58086
		internal static int __PropertyOffset_HaloMinDrawDistance;

		// Token: 0x0400E2E7 RID: 58087
		internal static int __PropertyOffset_HaloMaxDrawDistance;

		// Token: 0x0400E2E8 RID: 58088
		internal static int __PropertyOffset_HaloMinDrawFadeRange;

		// Token: 0x0400E2E9 RID: 58089
		internal static int __PropertyOffset_HaloMaxDrawFadeRange;

		// Token: 0x0400E2EA RID: 58090
		internal static int __PropertyOffset_LightRadius;

		// Token: 0x0400E2EB RID: 58091
		internal static int __PropertyOffset_BoxExtent;
	}
}
