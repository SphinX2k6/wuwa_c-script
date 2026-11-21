using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000240 RID: 576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MemberReference")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMemberReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003168 RID: 12648 RVA: 0x00046569 File Offset: 0x00044769
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMemberReference._ScriptStructPtr != 0) ? FMemberReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MemberReference", ref FMemberReference._ScriptStructPtr);
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0004658D File Offset: 0x0004478D
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x000465A1 File Offset: 0x000447A1
		[Nullable(2)]
		public unsafe UObject MemberParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FMemberReference.__PropertyOffset_MemberParent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMemberReference.__PropertyOffset_MemberParent, value);
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000465B6 File Offset: 0x000447B6
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x000465CA File Offset: 0x000447CA
		public unsafe string MemberScope
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMemberReference.__PropertyOffset_MemberScope)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMemberReference.__PropertyOffset_MemberScope)), value);
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000465DF File Offset: 0x000447DF
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x000465F3 File Offset: 0x000447F3
		public unsafe FName MemberName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_MemberName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_MemberName) = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x00046608 File Offset: 0x00044808
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x0004661C File Offset: 0x0004481C
		public unsafe FGuid MemberGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_MemberGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_MemberGuid) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x00046631 File Offset: 0x00044831
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x00046641 File Offset: 0x00044841
		public unsafe bool bSelfContext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_bSelfContext) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_bSelfContext) = (value ? 1 : 0);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x00046652 File Offset: 0x00044852
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x00046662 File Offset: 0x00044862
		public unsafe bool bWasDeprecated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_bWasDeprecated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMemberReference.__PropertyOffset_bWasDeprecated) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00046673 File Offset: 0x00044873
		public FMemberReference()
		{
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0004667B File Offset: 0x0004487B
		protected override IntPtr GetUStructPtr()
		{
			return FMemberReference.StaticStruct();
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00046687 File Offset: 0x00044887
		[NullableContext(2)]
		public FMemberReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00046691 File Offset: 0x00044891
		public FMemberReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x0004669C File Offset: 0x0004489C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMemberReference(Pointer, false, true);
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000466A6 File Offset: 0x000448A6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMemberReference(Pointer, MemoryOwner);
		}

		// Token: 0x040010F0 RID: 4336
		public const string __ObjectPath = "/Script/Engine.MemberReference";

		// Token: 0x040010F1 RID: 4337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010F2 RID: 4338
		internal static int __PropertyOffset_MemberParent;

		// Token: 0x040010F3 RID: 4339
		internal static int __PropertyOffset_MemberScope;

		// Token: 0x040010F4 RID: 4340
		internal static int __PropertyOffset_MemberName;

		// Token: 0x040010F5 RID: 4341
		internal static int __PropertyOffset_MemberGuid;

		// Token: 0x040010F6 RID: 4342
		internal static int __PropertyOffset_bSelfContext;

		// Token: 0x040010F7 RID: 4343
		internal static int __PropertyOffset_bWasDeprecated;
	}
}
