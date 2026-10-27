using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D35 RID: 3381
	[UnrealObjectPath("/Script/Engine.LevelScriptActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ALevelScriptActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4FA RID: 46330 RVA: 0x0010227E File Offset: 0x0010047E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelScriptActor._ClassPtr;
		}

		// Token: 0x0600B4FB RID: 46331 RVA: 0x0010228C File Offset: 0x0010048C
		public ALevelScriptActor() : this(BuiltinUtils.AllocNativeUObject(ALevelScriptActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x001022B4 File Offset: 0x001004B4
		[NullableContext(1)]
		public ALevelScriptActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelScriptActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x0600B4FD RID: 46333 RVA: 0x001022E7 File Offset: 0x001004E7
		// (set) Token: 0x0600B4FE RID: 46334 RVA: 0x00102300 File Offset: 0x00100500
		public unsafe bool bInputEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ALevelScriptActor.__PropertyOffset_bInputEnabled) & ALevelScriptActor.__PropertyMask_bInputEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ALevelScriptActor.__PropertyOffset_bInputEnabled) = ((*(base.NativePtr + (IntPtr)ALevelScriptActor.__PropertyOffset_bInputEnabled) & ~ALevelScriptActor.__PropertyMask_bInputEnabled) | (value ? ALevelScriptActor.__PropertyMask_bInputEnabled : 0));
			}
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x00102330 File Offset: 0x00100530
		public virtual void WorldOriginLocationChanged(FIntVector OldOriginLocation, FIntVector NewOriginLocation)
		{
			ALevelScriptActor.__WorldOriginLocationChanged_Internal(base.NativePtr, OldOriginLocation, NewOriginLocation);
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x0010233F File Offset: 0x0010053F
		public void SetCinematicMode(bool bCinematicMode, bool bHidePlayer = true, bool bAffectsHUD = true, bool bAffectsMovement = false, bool bAffectsTurning = false)
		{
			ALevelScriptActor.__SetCinematicMode_Internal(base.NativePtr, bCinematicMode, bHidePlayer, bAffectsHUD, bAffectsMovement, bAffectsTurning);
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x00102353 File Offset: 0x00100553
		public bool RemoteEvent(FName EventName)
		{
			return ALevelScriptActor.__RemoteEvent_Internal(base.NativePtr, EventName);
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x00102361 File Offset: 0x00100561
		public virtual void LevelReset()
		{
			ALevelScriptActor.__LevelReset_Internal(base.NativePtr);
		}

		// Token: 0x0600B503 RID: 46339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WorldOriginLocationChanged_Internal(IntPtr @this, FIntVector OldOriginLocation, FIntVector NewOriginLocation);

		// Token: 0x0600B504 RID: 46340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCinematicMode_Internal(IntPtr @this, bool bCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning);

		// Token: 0x0600B505 RID: 46341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoteEvent_Internal(IntPtr @this, FName EventName);

		// Token: 0x0600B506 RID: 46342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LevelReset_Internal(IntPtr @this);

		// Token: 0x0600B507 RID: 46343 RVA: 0x0010236E File Offset: 0x0010056E
		static ALevelScriptActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelScriptActor");
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x0010237C File Offset: 0x0010057C
		protected ALevelScriptActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F22 RID: 24354
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelScriptActor";

		// Token: 0x04005F23 RID: 24355
		private static IntPtr _ClassPtr;

		// Token: 0x04005F24 RID: 24356
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005F25 RID: 24357
		internal static int __PropertyOffset_bInputEnabled;

		// Token: 0x04005F26 RID: 24358
		internal static byte __PropertyMask_bInputEnabled;

		// Token: 0x02002D3D RID: 11581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __WorldOriginLocationChanged_FunctionParams
		{
			// Token: 0x04016740 RID: 91968
			[FieldOffset(0)]
			public FIntVector OldOriginLocation;

			// Token: 0x04016741 RID: 91969
			[FieldOffset(12)]
			public FIntVector NewOriginLocation;
		}
	}
}
