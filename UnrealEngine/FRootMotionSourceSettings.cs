using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010A1 RID: 4257
	[UnrealObjectPath("/Script/Engine.RootMotionSourceSettings")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FRootMotionSourceSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F35C RID: 62300 RVA: 0x00168F0E File Offset: 0x0016710E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSourceSettings._ScriptStructPtr != 0) ? FRootMotionSourceSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSourceSettings", ref FRootMotionSourceSettings._ScriptStructPtr);
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x0600F35D RID: 62301 RVA: 0x00168F32 File Offset: 0x00167132
		// (set) Token: 0x0600F35E RID: 62302 RVA: 0x00168F42 File Offset: 0x00167142
		public unsafe byte Flags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSourceSettings.__PropertyOffset_Flags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSourceSettings.__PropertyOffset_Flags) = value;
			}
		}

		// Token: 0x0600F35F RID: 62303 RVA: 0x00168F53 File Offset: 0x00167153
		public FRootMotionSourceSettings()
		{
		}

		// Token: 0x0600F360 RID: 62304 RVA: 0x00168F5B File Offset: 0x0016715B
		public FRootMotionSourceSettings(byte Flags)
		{
			this.Flags = Flags;
		}

		// Token: 0x0600F361 RID: 62305 RVA: 0x00168F6A File Offset: 0x0016716A
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSourceSettings.StaticStruct();
		}

		// Token: 0x0600F362 RID: 62306 RVA: 0x00168F76 File Offset: 0x00167176
		[NullableContext(2)]
		public FRootMotionSourceSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F363 RID: 62307 RVA: 0x00168F80 File Offset: 0x00167180
		public FRootMotionSourceSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F364 RID: 62308 RVA: 0x00168F8B File Offset: 0x0016718B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSourceSettings(Pointer, false, true);
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x00168F95 File Offset: 0x00167195
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSourceSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040083FA RID: 33786
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RootMotionSourceSettings";

		// Token: 0x040083FB RID: 33787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083FC RID: 33788
		internal static int __PropertyOffset_Flags;
	}
}
