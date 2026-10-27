using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E3 RID: 227
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIDamageEvent")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAIDamageEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x0001B3DF File Offset: 0x000195DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIDamageEvent._ScriptStructPtr != 0) ? FAIDamageEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIDamageEvent", ref FAIDamageEvent._ScriptStructPtr);
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0001B403 File Offset: 0x00019603
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x0001B413 File Offset: 0x00019613
		public unsafe float Amount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDamageEvent.__PropertyOffset_Amount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDamageEvent.__PropertyOffset_Amount) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x0001B424 File Offset: 0x00019624
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0001B438 File Offset: 0x00019638
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDamageEvent.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDamageEvent.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0001B44D File Offset: 0x0001964D
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x0001B461 File Offset: 0x00019661
		public unsafe FVector HitLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIDamageEvent.__PropertyOffset_HitLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIDamageEvent.__PropertyOffset_HitLocation) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0001B476 File Offset: 0x00019676
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x0001B48A File Offset: 0x0001968A
		public unsafe AActor DamagedActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAIDamageEvent.__PropertyOffset_DamagedActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAIDamageEvent.__PropertyOffset_DamagedActor, value);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0001B49F File Offset: 0x0001969F
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x0001B4B3 File Offset: 0x000196B3
		public unsafe AActor Instigator
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAIDamageEvent.__PropertyOffset_Instigator);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAIDamageEvent.__PropertyOffset_Instigator, value);
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0001B4C8 File Offset: 0x000196C8
		public FAIDamageEvent()
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0001B4D0 File Offset: 0x000196D0
		[NullableContext(1)]
		public FAIDamageEvent(float Amount, FVector Location, FVector HitLocation, AActor DamagedActor, AActor Instigator)
		{
			this.Amount = Amount;
			this.Location = Location;
			this.HitLocation = HitLocation;
			this.DamagedActor = DamagedActor;
			this.Instigator = Instigator;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0001B4FD File Offset: 0x000196FD
		protected override IntPtr GetUStructPtr()
		{
			return FAIDamageEvent.StaticStruct();
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0001B509 File Offset: 0x00019709
		public FAIDamageEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0001B513 File Offset: 0x00019713
		public FAIDamageEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0001B51E File Offset: 0x0001971E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIDamageEvent(Pointer, false, true);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0001B528 File Offset: 0x00019728
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIDamageEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04000319 RID: 793
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIDamageEvent";

		// Token: 0x0400031A RID: 794
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400031B RID: 795
		internal static int __PropertyOffset_Amount;

		// Token: 0x0400031C RID: 796
		internal static int __PropertyOffset_Location;

		// Token: 0x0400031D RID: 797
		internal static int __PropertyOffset_HitLocation;

		// Token: 0x0400031E RID: 798
		internal static int __PropertyOffset_DamagedActor;

		// Token: 0x0400031F RID: 799
		internal static int __PropertyOffset_Instigator;
	}
}
