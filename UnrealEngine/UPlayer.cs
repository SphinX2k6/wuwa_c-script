using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200100A RID: 4106
	[UnrealObjectPath("/Script/Engine.Player")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UPlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DE3B RID: 56891 RVA: 0x00147AB6 File Offset: 0x00145CB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlayer._ClassPtr;
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x00147AC4 File Offset: 0x00145CC4
		public UPlayer() : this(BuiltinUtils.AllocNativeUObject(UPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DE3D RID: 56893 RVA: 0x00147AEC File Offset: 0x00145CEC
		[NullableContext(1)]
		public UPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600DE3E RID: 56894 RVA: 0x00147B1F File Offset: 0x00145D1F
		// (set) Token: 0x0600DE3F RID: 56895 RVA: 0x00147B33 File Offset: 0x00145D33
		[Nullable(2)]
		public unsafe APlayerController PlayerController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + UPlayer.__PropertyOffset_PlayerController);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlayer.__PropertyOffset_PlayerController, value);
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600DE40 RID: 56896 RVA: 0x00147B48 File Offset: 0x00145D48
		// (set) Token: 0x0600DE41 RID: 56897 RVA: 0x00147B58 File Offset: 0x00145D58
		public unsafe int CurrentNetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlayer.__PropertyOffset_CurrentNetSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlayer.__PropertyOffset_CurrentNetSpeed) = value;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600DE42 RID: 56898 RVA: 0x00147B69 File Offset: 0x00145D69
		// (set) Token: 0x0600DE43 RID: 56899 RVA: 0x00147B79 File Offset: 0x00145D79
		public unsafe int ConfiguredInternetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlayer.__PropertyOffset_ConfiguredInternetSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlayer.__PropertyOffset_ConfiguredInternetSpeed) = value;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x00147B8A File Offset: 0x00145D8A
		// (set) Token: 0x0600DE45 RID: 56901 RVA: 0x00147B9A File Offset: 0x00145D9A
		public unsafe int ConfiguredLanSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPlayer.__PropertyOffset_ConfiguredLanSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPlayer.__PropertyOffset_ConfiguredLanSpeed) = value;
			}
		}

		// Token: 0x0600DE46 RID: 56902 RVA: 0x00147BAB File Offset: 0x00145DAB
		static UPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Player");
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x00147BB9 File Offset: 0x00145DB9
		protected UPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007811 RID: 30737
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Player";

		// Token: 0x04007812 RID: 30738
		private static IntPtr _ClassPtr;

		// Token: 0x04007813 RID: 30739
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007814 RID: 30740
		internal static int __PropertyOffset_PlayerController;

		// Token: 0x04007815 RID: 30741
		internal static int __PropertyOffset_CurrentNetSpeed;

		// Token: 0x04007816 RID: 30742
		internal static int __PropertyOffset_ConfiguredInternetSpeed;

		// Token: 0x04007817 RID: 30743
		internal static int __PropertyOffset_ConfiguredLanSpeed;
	}
}
