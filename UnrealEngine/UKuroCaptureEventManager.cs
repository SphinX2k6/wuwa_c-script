using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200268B RID: 9867
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.KuroCaptureEventManager")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroCaptureEventManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249FC RID: 150012 RVA: 0x003638F2 File Offset: 0x00361AF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCaptureEventManager._ClassPtr;
		}

		// Token: 0x060249FD RID: 150013 RVA: 0x00363900 File Offset: 0x00361B00
		public UKuroCaptureEventManager() : this(BuiltinUtils.AllocNativeUObject(UKuroCaptureEventManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249FE RID: 150014 RVA: 0x00363928 File Offset: 0x00361B28
		public UKuroCaptureEventManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCaptureEventManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D37 RID: 36151
		// (get) Token: 0x060249FF RID: 150015 RVA: 0x0036395C File Offset: 0x00361B5C
		// (set) Token: 0x06024A00 RID: 150016 RVA: 0x00363995 File Offset: 0x00361B95
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

		// Token: 0x06024A01 RID: 150017 RVA: 0x003639B6 File Offset: 0x00361BB6
		[NullableContext(2)]
		public static UKuroCaptureEventManager Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCaptureEventManager>(UKuroCaptureEventManager.__Get_Internal());
		}

		// Token: 0x06024A02 RID: 150018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal();

		// Token: 0x06024A03 RID: 150019 RVA: 0x003639C2 File Offset: 0x00361BC2
		static UKuroCaptureEventManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.KuroCaptureEventManager");
		}

		// Token: 0x06024A04 RID: 150020 RVA: 0x003639D0 File Offset: 0x00361BD0
		protected UKuroCaptureEventManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B12 RID: 80658
		public new const string __ObjectPath = "/Script/Renderer.KuroCaptureEventManager";

		// Token: 0x04013B13 RID: 80659
		private static IntPtr _ClassPtr;

		// Token: 0x04013B14 RID: 80660
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013B15 RID: 80661
		internal static int __PropertyOffset_OnSceneColorCaptured;

		// Token: 0x04013B16 RID: 80662
		[Nullable(2)]
		private FOnSceneColorCapturedDelegate _OnSceneColorCaptured;
	}
}
