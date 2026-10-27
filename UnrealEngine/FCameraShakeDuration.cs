using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000912 RID: 2322
	[UnrealObjectPath("/Script/Engine.CameraShakeDuration")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FCameraShakeDuration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007FCC RID: 32716 RVA: 0x000B72A1 File Offset: 0x000B54A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraShakeDuration._ScriptStructPtr != 0) ? FCameraShakeDuration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraShakeDuration", ref FCameraShakeDuration._ScriptStructPtr);
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x000B72C5 File Offset: 0x000B54C5
		// (set) Token: 0x06007FCE RID: 32718 RVA: 0x000B72D5 File Offset: 0x000B54D5
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x000B72E6 File Offset: 0x000B54E6
		// (set) Token: 0x06007FD0 RID: 32720 RVA: 0x000B72F6 File Offset: 0x000B54F6
		public unsafe ECameraShakeDurationType Type
		{
			get
			{
				return (ECameraShakeDurationType)(*(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeDuration.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x000B7307 File Offset: 0x000B5507
		public FCameraShakeDuration()
		{
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x000B730F File Offset: 0x000B550F
		public FCameraShakeDuration(float Duration, ECameraShakeDurationType Type)
		{
			this.Duration = Duration;
			this.Type = Type;
		}

		// Token: 0x06007FD3 RID: 32723 RVA: 0x000B7325 File Offset: 0x000B5525
		protected override IntPtr GetUStructPtr()
		{
			return FCameraShakeDuration.StaticStruct();
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x000B7331 File Offset: 0x000B5531
		[NullableContext(2)]
		public FCameraShakeDuration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x000B733B File Offset: 0x000B553B
		public FCameraShakeDuration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x000B7346 File Offset: 0x000B5546
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraShakeDuration(Pointer, false, true);
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x000B7350 File Offset: 0x000B5550
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraShakeDuration(Pointer, MemoryOwner);
		}

		// Token: 0x04003D45 RID: 15685
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraShakeDuration";

		// Token: 0x04003D46 RID: 15686
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D47 RID: 15687
		internal static int __PropertyOffset_Duration;

		// Token: 0x04003D48 RID: 15688
		internal static int __PropertyOffset_Type;
	}
}
