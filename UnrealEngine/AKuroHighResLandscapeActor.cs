using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B23 RID: 6947
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHighResLandscapeActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroHighResLandscapeActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A2BC RID: 107196 RVA: 0x0026A664 File Offset: 0x00268864
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroHighResLandscapeActor._ClassPtr;
		}

		// Token: 0x0601A2BD RID: 107197 RVA: 0x0026A670 File Offset: 0x00268870
		public AKuroHighResLandscapeActor() : this(BuiltinUtils.AllocNativeUObject(AKuroHighResLandscapeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A2BE RID: 107198 RVA: 0x0026A698 File Offset: 0x00268898
		[NullableContext(1)]
		public AKuroHighResLandscapeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroHighResLandscapeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006935 RID: 26933
		// (get) Token: 0x0601A2BF RID: 107199 RVA: 0x0026A6CB File Offset: 0x002688CB
		// (set) Token: 0x0601A2C0 RID: 107200 RVA: 0x0026A6DB File Offset: 0x002688DB
		public unsafe bool bIsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHighResLandscapeActor.__PropertyOffset_bIsEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHighResLandscapeActor.__PropertyOffset_bIsEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006936 RID: 26934
		// (get) Token: 0x0601A2C1 RID: 107201 RVA: 0x0026A6EC File Offset: 0x002688EC
		// (set) Token: 0x0601A2C2 RID: 107202 RVA: 0x0026A6FC File Offset: 0x002688FC
		public unsafe bool bUseProxyEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroHighResLandscapeActor.__PropertyOffset_bUseProxyEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroHighResLandscapeActor.__PropertyOffset_bUseProxyEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A2C3 RID: 107203 RVA: 0x0026A70D File Offset: 0x0026890D
		public void UpdateLandscapeStatus([Nullable(new byte[]
		{
			2,
			1
		})] TArray<ALandscapeStreamingProxy> LowLandProxies, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<ALandscapeStreamingProxy> HighLandProxies)
		{
			AKuroHighResLandscapeActor.__UpdateLandscapeStatus_Internal(base.NativePtr, (LowLandProxies ?? new TArray<ALandscapeStreamingProxy>()).NativePtr, (HighLandProxies ?? new TArray<ALandscapeStreamingProxy>()).NativePtr);
		}

		// Token: 0x0601A2C4 RID: 107204 RVA: 0x0026A738 File Offset: 0x00268938
		public void SetLandscapeComponentVisible(ALandscapeStreamingProxy Proxy, int ComponentIndex, bool IsVisible)
		{
			AKuroHighResLandscapeActor.__SetLandscapeComponentVisible_Internal(base.NativePtr, (Proxy != null) ? Proxy.NativePtr : IntPtr.Zero, ComponentIndex, IsVisible);
		}

		// Token: 0x0601A2C5 RID: 107205 RVA: 0x0026A757 File Offset: 0x00268957
		public void OnShowLandscapeStreamingProxy(ALandscapeStreamingProxy Proxy)
		{
			AKuroHighResLandscapeActor.__OnShowLandscapeStreamingProxy_Internal(base.NativePtr, (Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A2C6 RID: 107206 RVA: 0x0026A774 File Offset: 0x00268974
		public virtual void OnProxyShow(ALandscapeStreamingProxy Proxy)
		{
			AKuroHighResLandscapeActor.__OnProxyShow_Internal(base.NativePtr, (Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A2C7 RID: 107207 RVA: 0x0026A791 File Offset: 0x00268991
		public virtual void OnProxyHide(ALandscapeStreamingProxy Proxy)
		{
			AKuroHighResLandscapeActor.__OnProxyHide_Internal(base.NativePtr, (Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A2C8 RID: 107208 RVA: 0x0026A7AE File Offset: 0x002689AE
		public void OnHideLandscapeStreamingProxy(ALandscapeStreamingProxy Proxy)
		{
			AKuroHighResLandscapeActor.__OnHideLandscapeStreamingProxy_Internal(base.NativePtr, (Proxy != null) ? Proxy.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601A2C9 RID: 107209 RVA: 0x0026A7CB File Offset: 0x002689CB
		public bool IsEnabled()
		{
			return AKuroHighResLandscapeActor.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0601A2CA RID: 107210 RVA: 0x0026A7D8 File Offset: 0x002689D8
		public bool GetLandscapeComponentVisible(ALandscapeStreamingProxy Proxy, int ComponentIndex)
		{
			return AKuroHighResLandscapeActor.__GetLandscapeComponentVisible_Internal(base.NativePtr, (Proxy != null) ? Proxy.NativePtr : IntPtr.Zero, ComponentIndex);
		}

		// Token: 0x0601A2CB RID: 107211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLandscapeStatus_Internal(IntPtr @this, IntPtr LowLandProxies, IntPtr HighLandProxies);

		// Token: 0x0601A2CC RID: 107212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLandscapeComponentVisible_Internal(IntPtr @this, IntPtr Proxy, int ComponentIndex, bool IsVisible);

		// Token: 0x0601A2CD RID: 107213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnShowLandscapeStreamingProxy_Internal(IntPtr @this, IntPtr Proxy);

		// Token: 0x0601A2CE RID: 107214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnProxyShow_Internal(IntPtr @this, IntPtr Proxy);

		// Token: 0x0601A2CF RID: 107215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnProxyHide_Internal(IntPtr @this, IntPtr Proxy);

		// Token: 0x0601A2D0 RID: 107216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHideLandscapeStreamingProxy_Internal(IntPtr @this, IntPtr Proxy);

		// Token: 0x0601A2D1 RID: 107217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x0601A2D2 RID: 107218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLandscapeComponentVisible_Internal(IntPtr @this, IntPtr Proxy, int ComponentIndex);

		// Token: 0x0601A2D3 RID: 107219 RVA: 0x0026A7F6 File Offset: 0x002689F6
		static AKuroHighResLandscapeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHighResLandscapeActor");
		}

		// Token: 0x0601A2D4 RID: 107220 RVA: 0x0026A804 File Offset: 0x00268A04
		protected AKuroHighResLandscapeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E382 RID: 58242
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHighResLandscapeActor";

		// Token: 0x0400E383 RID: 58243
		private static IntPtr _ClassPtr;

		// Token: 0x0400E384 RID: 58244
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E385 RID: 58245
		internal static int __PropertyOffset_bIsEnable;

		// Token: 0x0400E386 RID: 58246
		internal static int __PropertyOffset_bUseProxyEvent;

		// Token: 0x02003151 RID: 12625
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnProxyShow_FunctionParams
		{
			// Token: 0x04016F68 RID: 94056
			[FieldOffset(0)]
			public IntPtr Proxy;
		}

		// Token: 0x02003152 RID: 12626
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnProxyHide_FunctionParams
		{
			// Token: 0x04016F69 RID: 94057
			[FieldOffset(0)]
			public IntPtr Proxy;
		}
	}
}
