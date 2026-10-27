using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D44 RID: 3396
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LightCastShadowCheck")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLightCastShadowCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B60E RID: 46606 RVA: 0x00103A6D File Offset: 0x00101C6D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightCastShadowCheck._ScriptStructPtr != 0) ? FLightCastShadowCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightCastShadowCheck", ref FLightCastShadowCheck._ScriptStructPtr);
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x00103A91 File Offset: 0x00101C91
		// (set) Token: 0x0600B610 RID: 46608 RVA: 0x00103AA5 File Offset: 0x00101CA5
		public unsafe string Folder
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLightCastShadowCheck.__PropertyOffset_Folder)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLightCastShadowCheck.__PropertyOffset_Folder)), value);
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0600B611 RID: 46609 RVA: 0x00103ABA File Offset: 0x00101CBA
		// (set) Token: 0x0600B612 RID: 46610 RVA: 0x00103ACE File Offset: 0x00101CCE
		public unsafe string CastShadows
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLightCastShadowCheck.__PropertyOffset_CastShadows)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLightCastShadowCheck.__PropertyOffset_CastShadows)), value);
			}
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x00103AE3 File Offset: 0x00101CE3
		public FLightCastShadowCheck()
		{
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x00103AEB File Offset: 0x00101CEB
		public FLightCastShadowCheck(string Folder, string CastShadows)
		{
			this.Folder = Folder;
			this.CastShadows = CastShadows;
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x00103B01 File Offset: 0x00101D01
		protected override IntPtr GetUStructPtr()
		{
			return FLightCastShadowCheck.StaticStruct();
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x00103B0D File Offset: 0x00101D0D
		[NullableContext(2)]
		public FLightCastShadowCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x00103B17 File Offset: 0x00101D17
		public FLightCastShadowCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x00103B22 File Offset: 0x00101D22
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightCastShadowCheck(Pointer, false, true);
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x00103B2C File Offset: 0x00101D2C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightCastShadowCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04005FA0 RID: 24480
		public const string __ObjectPath = "/Script/Engine.LightCastShadowCheck";

		// Token: 0x04005FA1 RID: 24481
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005FA2 RID: 24482
		internal static int __PropertyOffset_Folder;

		// Token: 0x04005FA3 RID: 24483
		internal static int __PropertyOffset_CastShadows;
	}
}
