using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200046D RID: 1133
	[UnrealObjectPath("/Script/Chaos.SolverCollisionFilterSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSolverCollisionFilterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x0005B214 File Offset: 0x00059414
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverCollisionFilterSettings._ScriptStructPtr != 0) ? FSolverCollisionFilterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.SolverCollisionFilterSettings", ref FSolverCollisionFilterSettings._ScriptStructPtr);
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0005B238 File Offset: 0x00059438
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x0005B248 File Offset: 0x00059448
		public unsafe bool FilterEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_FilterEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_FilterEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x0005B259 File Offset: 0x00059459
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x0005B269 File Offset: 0x00059469
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x0005B27A File Offset: 0x0005947A
		// (set) Token: 0x06003C80 RID: 15488 RVA: 0x0005B28A File Offset: 0x0005948A
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x0005B29B File Offset: 0x0005949B
		// (set) Token: 0x06003C82 RID: 15490 RVA: 0x0005B2AB File Offset: 0x000594AB
		public unsafe float MinImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_MinImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionFilterSettings.__PropertyOffset_MinImpulse) = value;
			}
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x0005B2BC File Offset: 0x000594BC
		public FSolverCollisionFilterSettings()
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0005B2C4 File Offset: 0x000594C4
		public FSolverCollisionFilterSettings(bool FilterEnabled, float MinMass, float MinSpeed, float MinImpulse)
		{
			this.FilterEnabled = FilterEnabled;
			this.MinMass = MinMass;
			this.MinSpeed = MinSpeed;
			this.MinImpulse = MinImpulse;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x0005B2E9 File Offset: 0x000594E9
		protected override IntPtr GetUStructPtr()
		{
			return FSolverCollisionFilterSettings.StaticStruct();
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x0005B2F5 File Offset: 0x000594F5
		[NullableContext(2)]
		public FSolverCollisionFilterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0005B2FF File Offset: 0x000594FF
		public FSolverCollisionFilterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x0005B30A File Offset: 0x0005950A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverCollisionFilterSettings(Pointer, false, true);
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x0005B314 File Offset: 0x00059514
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverCollisionFilterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C5F RID: 7263
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Chaos.SolverCollisionFilterSettings";

		// Token: 0x04001C60 RID: 7264
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C61 RID: 7265
		internal static int __PropertyOffset_FilterEnabled;

		// Token: 0x04001C62 RID: 7266
		internal static int __PropertyOffset_MinMass;

		// Token: 0x04001C63 RID: 7267
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x04001C64 RID: 7268
		internal static int __PropertyOffset_MinImpulse;
	}
}
