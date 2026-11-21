using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C0 RID: 1984
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.KuroCaptureEventManager")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroCaptureEventManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABC7 RID: 43975 RVA: 0x000FD579 File Offset: 0x000FB779
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCaptureEventManager._ClassPtr;
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x000FD588 File Offset: 0x000FB788
		public UKuroCaptureEventManager() : this(BuiltinUtils.AllocNativeUObject(UKuroCaptureEventManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x000FD5B0 File Offset: 0x000FB7B0
		public UKuroCaptureEventManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCaptureEventManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x0600ABCA RID: 43978 RVA: 0x000FD5E4 File Offset: 0x000FB7E4
		// (set) Token: 0x0600ABCB RID: 43979 RVA: 0x000FD61D File Offset: 0x000FB81D
		public FOnSceneColorCapturedDelegate OnSceneColorCaptured
		{
			get
			{
				base.FastCheckIsValid();
				FOnSceneColorCapturedDelegate result;
				if ((result = this._OnSceneColorCaptured) == null)
				{
					result = (this._OnSceneColorCaptured = new FOnSceneColorCapturedDelegate(base.NativePtr + (IntPtr)UKuroCaptureEventManager.__PropertyOffset_OnSceneColorCaptured, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroCaptureEventManager.__PropertyOffset_OnSceneColorCaptured, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x000FD63E File Offset: 0x000FB83E
		[NullableContext(2)]
		public static UKuroCaptureEventManager Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCaptureEventManager>(UKuroCaptureEventManager.__Get_Internal());
		}

		// Token: 0x0600ABCD RID: 43981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal();

		// Token: 0x0600ABCE RID: 43982 RVA: 0x000FD64A File Offset: 0x000FB84A
		static UKuroCaptureEventManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.KuroCaptureEventManager");
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x000FD658 File Offset: 0x000FB858
		protected UKuroCaptureEventManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049DD RID: 18909
		public new const string __ObjectPath = "/Script/Renderer.KuroCaptureEventManager";

		// Token: 0x040049DE RID: 18910
		private static IntPtr _ClassPtr;

		// Token: 0x040049DF RID: 18911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049E0 RID: 18912
		internal static int __PropertyOffset_OnSceneColorCaptured;

		// Token: 0x040049E1 RID: 18913
		[Nullable(2)]
		private FOnSceneColorCapturedDelegate _OnSceneColorCaptured;
	}
}
