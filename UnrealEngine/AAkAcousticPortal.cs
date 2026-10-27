using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001E2 RID: 482
	[UnrealObjectPath("/Script/AkAudio.AkAcousticPortal")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class AAkAcousticPortal : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C6C RID: 7276 RVA: 0x0002A711 File Offset: 0x00028911
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAkAcousticPortal._ClassPtr;
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0002A720 File Offset: 0x00028920
		public AAkAcousticPortal() : this(BuiltinUtils.AllocNativeUObject(AAkAcousticPortal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0002A748 File Offset: 0x00028948
		[NullableContext(1)]
		public AAkAcousticPortal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAkAcousticPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x0002A77B File Offset: 0x0002897B
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0002A78F File Offset: 0x0002898F
		[Nullable(2)]
		public unsafe UAkPortalComponent Portal
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkPortalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAkAcousticPortal.__PropertyOffset_Portal);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAkAcousticPortal.__PropertyOffset_Portal, value);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0002A7A4 File Offset: 0x000289A4
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0002A7B4 File Offset: 0x000289B4
		public unsafe EAkAcousticPortalState InitialState
		{
			get
			{
				return (EAkAcousticPortalState)(*(base.NativePtr + (IntPtr)AAkAcousticPortal.__PropertyOffset_InitialState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkAcousticPortal.__PropertyOffset_InitialState) = (byte)value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0002A7C5 File Offset: 0x000289C5
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0002A7D5 File Offset: 0x000289D5
		public unsafe bool bRequiresStateMigration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkAcousticPortal.__PropertyOffset_bRequiresStateMigration) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkAcousticPortal.__PropertyOffset_bRequiresStateMigration) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0002A7E6 File Offset: 0x000289E6
		public void OpenPortal()
		{
			AAkAcousticPortal.__OpenPortal_Internal(base.NativePtr);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0002A7F3 File Offset: 0x000289F3
		public EAkAcousticPortalState GetCurrentState()
		{
			return AAkAcousticPortal.__GetCurrentState_Internal(base.NativePtr);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0002A800 File Offset: 0x00028A00
		public void ClosePortal()
		{
			AAkAcousticPortal.__ClosePortal_Internal(base.NativePtr);
		}

		// Token: 0x06001C78 RID: 7288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenPortal_Internal(IntPtr @this);

		// Token: 0x06001C79 RID: 7289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EAkAcousticPortalState __GetCurrentState_Internal(IntPtr @this);

		// Token: 0x06001C7A RID: 7290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClosePortal_Internal(IntPtr @this);

		// Token: 0x06001C7B RID: 7291 RVA: 0x0002A80D File Offset: 0x00028A0D
		static AAkAcousticPortal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAcousticPortal");
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0002A81B File Offset: 0x00028A1B
		protected AAkAcousticPortal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000943 RID: 2371
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAcousticPortal";

		// Token: 0x04000944 RID: 2372
		private static IntPtr _ClassPtr;

		// Token: 0x04000945 RID: 2373
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000946 RID: 2374
		internal static int __PropertyOffset_Portal;

		// Token: 0x04000947 RID: 2375
		internal static int __PropertyOffset_InitialState;

		// Token: 0x04000948 RID: 2376
		internal static int __PropertyOffset_bRequiresStateMigration;
	}
}
