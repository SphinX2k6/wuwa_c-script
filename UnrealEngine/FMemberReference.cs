using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E9F RID: 3743
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MemberReference")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMemberReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C9E3 RID: 51683 RVA: 0x00125EEB File Offset: 0x001240EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMemberReference._ScriptStructPtr != 0) ? FMemberReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MemberReference", ref FMemberReference._ScriptStructPtr);
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0600C9E4 RID: 51684 RVA: 0x00125F0F File Offset: 0x0012410F
		// (set) Token: 0x0600C9E5 RID: 51685 RVA: 0x00125F23 File Offset: 0x00124123
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

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0600C9E6 RID: 51686 RVA: 0x00125F38 File Offset: 0x00124138
		// (set) Token: 0x0600C9E7 RID: 51687 RVA: 0x00125F4C File Offset: 0x0012414C
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

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600C9E8 RID: 51688 RVA: 0x00125F61 File Offset: 0x00124161
		// (set) Token: 0x0600C9E9 RID: 51689 RVA: 0x00125F75 File Offset: 0x00124175
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

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600C9EA RID: 51690 RVA: 0x00125F8A File Offset: 0x0012418A
		// (set) Token: 0x0600C9EB RID: 51691 RVA: 0x00125F9E File Offset: 0x0012419E
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

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600C9EC RID: 51692 RVA: 0x00125FB3 File Offset: 0x001241B3
		// (set) Token: 0x0600C9ED RID: 51693 RVA: 0x00125FC3 File Offset: 0x001241C3
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

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x00125FD4 File Offset: 0x001241D4
		// (set) Token: 0x0600C9EF RID: 51695 RVA: 0x00125FE4 File Offset: 0x001241E4
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

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x00125FF5 File Offset: 0x001241F5
		public FMemberReference()
		{
		}

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x00125FFD File Offset: 0x001241FD
		public FMemberReference(UObject MemberParent, string MemberScope, FName MemberName, FGuid MemberGuid, bool bSelfContext, bool bWasDeprecated)
		{
			this.MemberParent = MemberParent;
			this.MemberScope = MemberScope;
			this.MemberName = MemberName;
			this.MemberGuid = MemberGuid;
			this.bSelfContext = bSelfContext;
			this.bWasDeprecated = bWasDeprecated;
		}

		// Token: 0x0600C9F2 RID: 51698 RVA: 0x00126032 File Offset: 0x00124232
		protected override IntPtr GetUStructPtr()
		{
			return FMemberReference.StaticStruct();
		}

		// Token: 0x0600C9F3 RID: 51699 RVA: 0x0012603E File Offset: 0x0012423E
		[NullableContext(2)]
		public FMemberReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C9F4 RID: 51700 RVA: 0x00126048 File Offset: 0x00124248
		public FMemberReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C9F5 RID: 51701 RVA: 0x00126053 File Offset: 0x00124253
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMemberReference(Pointer, false, true);
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x0012605D File Offset: 0x0012425D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMemberReference(Pointer, MemoryOwner);
		}

		// Token: 0x04006CAB RID: 27819
		public const string __ObjectPath = "/Script/Engine.MemberReference";

		// Token: 0x04006CAC RID: 27820
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006CAD RID: 27821
		internal static int __PropertyOffset_MemberParent;

		// Token: 0x04006CAE RID: 27822
		internal static int __PropertyOffset_MemberScope;

		// Token: 0x04006CAF RID: 27823
		internal static int __PropertyOffset_MemberName;

		// Token: 0x04006CB0 RID: 27824
		internal static int __PropertyOffset_MemberGuid;

		// Token: 0x04006CB1 RID: 27825
		internal static int __PropertyOffset_bSelfContext;

		// Token: 0x04006CB2 RID: 27826
		internal static int __PropertyOffset_bWasDeprecated;
	}
}
