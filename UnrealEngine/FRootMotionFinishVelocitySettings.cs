using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200109D RID: 4253
	[UnrealObjectPath("/Script/Engine.RootMotionFinishVelocitySettings")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRootMotionFinishVelocitySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F308 RID: 62216 RVA: 0x00168732 File Offset: 0x00166932
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionFinishVelocitySettings._ScriptStructPtr != 0) ? FRootMotionFinishVelocitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionFinishVelocitySettings", ref FRootMotionFinishVelocitySettings._ScriptStructPtr);
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0600F309 RID: 62217 RVA: 0x00168756 File Offset: 0x00166956
		// (set) Token: 0x0600F30A RID: 62218 RVA: 0x00168766 File Offset: 0x00166966
		public unsafe ERootMotionFinishVelocityMode Mode
		{
			get
			{
				return (ERootMotionFinishVelocityMode)(*(base.NativePtr + (IntPtr)FRootMotionFinishVelocitySettings.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionFinishVelocitySettings.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600F30B RID: 62219 RVA: 0x00168777 File Offset: 0x00166977
		// (set) Token: 0x0600F30C RID: 62220 RVA: 0x0016878B File Offset: 0x0016698B
		public unsafe FVector SetVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionFinishVelocitySettings.__PropertyOffset_SetVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionFinishVelocitySettings.__PropertyOffset_SetVelocity) = value;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600F30D RID: 62221 RVA: 0x001687A0 File Offset: 0x001669A0
		// (set) Token: 0x0600F30E RID: 62222 RVA: 0x001687B0 File Offset: 0x001669B0
		public unsafe float ClampVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionFinishVelocitySettings.__PropertyOffset_ClampVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionFinishVelocitySettings.__PropertyOffset_ClampVelocity) = value;
			}
		}

		// Token: 0x0600F30F RID: 62223 RVA: 0x001687C1 File Offset: 0x001669C1
		public FRootMotionFinishVelocitySettings()
		{
		}

		// Token: 0x0600F310 RID: 62224 RVA: 0x001687C9 File Offset: 0x001669C9
		public FRootMotionFinishVelocitySettings(ERootMotionFinishVelocityMode Mode, FVector SetVelocity, float ClampVelocity)
		{
			this.Mode = Mode;
			this.SetVelocity = SetVelocity;
			this.ClampVelocity = ClampVelocity;
		}

		// Token: 0x0600F311 RID: 62225 RVA: 0x001687E6 File Offset: 0x001669E6
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionFinishVelocitySettings.StaticStruct();
		}

		// Token: 0x0600F312 RID: 62226 RVA: 0x001687F2 File Offset: 0x001669F2
		[NullableContext(2)]
		public FRootMotionFinishVelocitySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F313 RID: 62227 RVA: 0x001687FC File Offset: 0x001669FC
		public FRootMotionFinishVelocitySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F314 RID: 62228 RVA: 0x00168807 File Offset: 0x00166A07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionFinishVelocitySettings(Pointer, false, true);
		}

		// Token: 0x0600F315 RID: 62229 RVA: 0x00168811 File Offset: 0x00166A11
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionFinishVelocitySettings(Pointer, MemoryOwner);
		}

		// Token: 0x040083CF RID: 33743
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RootMotionFinishVelocitySettings";

		// Token: 0x040083D0 RID: 33744
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083D1 RID: 33745
		internal static int __PropertyOffset_Mode;

		// Token: 0x040083D2 RID: 33746
		internal static int __PropertyOffset_SetVelocity;

		// Token: 0x040083D3 RID: 33747
		internal static int __PropertyOffset_ClampVelocity;
	}
}
