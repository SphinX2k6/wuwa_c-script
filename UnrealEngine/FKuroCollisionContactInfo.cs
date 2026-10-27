using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200182E RID: 6190
	[UnrealObjectPath("/Script/KuroFastCollision.KuroCollisionContactInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroCollisionContactInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016D3B RID: 93499 RVA: 0x0021540E File Offset: 0x0021360E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCollisionContactInfo._ScriptStructPtr != 0) ? FKuroCollisionContactInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroFastCollision.KuroCollisionContactInfo", ref FKuroCollisionContactInfo._ScriptStructPtr);
		}

		// Token: 0x17005C1C RID: 23580
		// (get) Token: 0x06016D3C RID: 93500 RVA: 0x00215432 File Offset: 0x00213632
		// (set) Token: 0x06016D3D RID: 93501 RVA: 0x00215446 File Offset: 0x00213646
		public unsafe FVector ContactPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCollisionContactInfo.__PropertyOffset_ContactPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCollisionContactInfo.__PropertyOffset_ContactPoint) = value;
			}
		}

		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x06016D3E RID: 93502 RVA: 0x0021545B File Offset: 0x0021365B
		// (set) Token: 0x06016D3F RID: 93503 RVA: 0x0021546F File Offset: 0x0021366F
		public unsafe FVector ContactNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCollisionContactInfo.__PropertyOffset_ContactNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCollisionContactInfo.__PropertyOffset_ContactNormal) = value;
			}
		}

		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x06016D40 RID: 93504 RVA: 0x00215484 File Offset: 0x00213684
		// (set) Token: 0x06016D41 RID: 93505 RVA: 0x00215494 File Offset: 0x00213694
		public unsafe float PenetrationDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCollisionContactInfo.__PropertyOffset_PenetrationDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCollisionContactInfo.__PropertyOffset_PenetrationDepth) = value;
			}
		}

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x06016D42 RID: 93506 RVA: 0x002154A5 File Offset: 0x002136A5
		// (set) Token: 0x06016D43 RID: 93507 RVA: 0x002154B9 File Offset: 0x002136B9
		[Nullable(2)]
		public unsafe UObject Agent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCollisionContactInfo.__PropertyOffset_Agent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCollisionContactInfo.__PropertyOffset_Agent, value);
			}
		}

		// Token: 0x06016D44 RID: 93508 RVA: 0x002154CE File Offset: 0x002136CE
		public FKuroCollisionContactInfo()
		{
		}

		// Token: 0x06016D45 RID: 93509 RVA: 0x002154D6 File Offset: 0x002136D6
		[NullableContext(1)]
		public FKuroCollisionContactInfo(FVector ContactPoint, FVector ContactNormal, float PenetrationDepth, UObject Agent)
		{
			this.ContactPoint = ContactPoint;
			this.ContactNormal = ContactNormal;
			this.PenetrationDepth = PenetrationDepth;
			this.Agent = Agent;
		}

		// Token: 0x06016D46 RID: 93510 RVA: 0x002154FB File Offset: 0x002136FB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCollisionContactInfo.StaticStruct();
		}

		// Token: 0x06016D47 RID: 93511 RVA: 0x00215507 File Offset: 0x00213707
		[NullableContext(2)]
		public FKuroCollisionContactInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D48 RID: 93512 RVA: 0x00215511 File Offset: 0x00213711
		public FKuroCollisionContactInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D49 RID: 93513 RVA: 0x0021551C File Offset: 0x0021371C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCollisionContactInfo(Pointer, false, true);
		}

		// Token: 0x06016D4A RID: 93514 RVA: 0x00215526 File Offset: 0x00213726
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCollisionContactInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400C695 RID: 50837
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFastCollision.KuroCollisionContactInfo";

		// Token: 0x0400C696 RID: 50838
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C697 RID: 50839
		internal static int __PropertyOffset_ContactPoint;

		// Token: 0x0400C698 RID: 50840
		internal static int __PropertyOffset_ContactNormal;

		// Token: 0x0400C699 RID: 50841
		internal static int __PropertyOffset_PenetrationDepth;

		// Token: 0x0400C69A RID: 50842
		internal static int __PropertyOffset_Agent;
	}
}
