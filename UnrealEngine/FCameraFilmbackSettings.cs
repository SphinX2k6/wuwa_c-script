using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000470 RID: 1136
	[UnrealObjectPath("/Script/CinematicCamera.CameraFilmbackSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCameraFilmbackSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003CAE RID: 15534 RVA: 0x0005B599 File Offset: 0x00059799
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraFilmbackSettings._ScriptStructPtr != 0) ? FCameraFilmbackSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraFilmbackSettings", ref FCameraFilmbackSettings._ScriptStructPtr);
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x0005B5BD File Offset: 0x000597BD
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x0005B5CD File Offset: 0x000597CD
		public unsafe float SensorWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorWidth) = value;
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x0005B5DE File Offset: 0x000597DE
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x0005B5EE File Offset: 0x000597EE
		public unsafe float SensorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorHeight) = value;
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x0005B5FF File Offset: 0x000597FF
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x0005B60F File Offset: 0x0005980F
		public unsafe float SensorAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFilmbackSettings.__PropertyOffset_SensorAspectRatio) = value;
			}
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x0005B620 File Offset: 0x00059820
		public FCameraFilmbackSettings()
		{
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x0005B628 File Offset: 0x00059828
		public FCameraFilmbackSettings(float SensorWidth, float SensorHeight, float SensorAspectRatio)
		{
			this.SensorWidth = SensorWidth;
			this.SensorHeight = SensorHeight;
			this.SensorAspectRatio = SensorAspectRatio;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x0005B645 File Offset: 0x00059845
		protected override IntPtr GetUStructPtr()
		{
			return FCameraFilmbackSettings.StaticStruct();
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x0005B651 File Offset: 0x00059851
		[NullableContext(2)]
		public FCameraFilmbackSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x0005B65B File Offset: 0x0005985B
		public FCameraFilmbackSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x0005B666 File Offset: 0x00059866
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraFilmbackSettings(Pointer, false, true);
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x0005B670 File Offset: 0x00059870
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraFilmbackSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C73 RID: 7283
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CinematicCamera.CameraFilmbackSettings";

		// Token: 0x04001C74 RID: 7284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C75 RID: 7285
		internal static int __PropertyOffset_SensorWidth;

		// Token: 0x04001C76 RID: 7286
		internal static int __PropertyOffset_SensorHeight;

		// Token: 0x04001C77 RID: 7287
		internal static int __PropertyOffset_SensorAspectRatio;
	}
}
