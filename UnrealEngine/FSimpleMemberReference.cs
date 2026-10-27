using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010ED RID: 4333
	[UnrealObjectPath("/Script/Engine.SimpleMemberReference")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSimpleMemberReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F89A RID: 63642 RVA: 0x0016FB5C File Offset: 0x0016DD5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimpleMemberReference._ScriptStructPtr != 0) ? FSimpleMemberReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SimpleMemberReference", ref FSimpleMemberReference._ScriptStructPtr);
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0600F89B RID: 63643 RVA: 0x0016FB80 File Offset: 0x0016DD80
		// (set) Token: 0x0600F89C RID: 63644 RVA: 0x0016FB94 File Offset: 0x0016DD94
		[Nullable(2)]
		public unsafe UObject MemberParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSimpleMemberReference.__PropertyOffset_MemberParent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSimpleMemberReference.__PropertyOffset_MemberParent, value);
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0600F89D RID: 63645 RVA: 0x0016FBA9 File Offset: 0x0016DDA9
		// (set) Token: 0x0600F89E RID: 63646 RVA: 0x0016FBBD File Offset: 0x0016DDBD
		public unsafe FName MemberName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleMemberReference.__PropertyOffset_MemberName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleMemberReference.__PropertyOffset_MemberName) = value;
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x0600F89F RID: 63647 RVA: 0x0016FBD2 File Offset: 0x0016DDD2
		// (set) Token: 0x0600F8A0 RID: 63648 RVA: 0x0016FBE6 File Offset: 0x0016DDE6
		public unsafe FGuid MemberGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleMemberReference.__PropertyOffset_MemberGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleMemberReference.__PropertyOffset_MemberGuid) = value;
			}
		}

		// Token: 0x0600F8A1 RID: 63649 RVA: 0x0016FBFB File Offset: 0x0016DDFB
		public FSimpleMemberReference()
		{
		}

		// Token: 0x0600F8A2 RID: 63650 RVA: 0x0016FC03 File Offset: 0x0016DE03
		[NullableContext(1)]
		public FSimpleMemberReference(UObject MemberParent, FName MemberName, FGuid MemberGuid)
		{
			this.MemberParent = MemberParent;
			this.MemberName = MemberName;
			this.MemberGuid = MemberGuid;
		}

		// Token: 0x0600F8A3 RID: 63651 RVA: 0x0016FC20 File Offset: 0x0016DE20
		protected override IntPtr GetUStructPtr()
		{
			return FSimpleMemberReference.StaticStruct();
		}

		// Token: 0x0600F8A4 RID: 63652 RVA: 0x0016FC2C File Offset: 0x0016DE2C
		[NullableContext(2)]
		public FSimpleMemberReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F8A5 RID: 63653 RVA: 0x0016FC36 File Offset: 0x0016DE36
		public FSimpleMemberReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F8A6 RID: 63654 RVA: 0x0016FC41 File Offset: 0x0016DE41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimpleMemberReference(Pointer, false, true);
		}

		// Token: 0x0600F8A7 RID: 63655 RVA: 0x0016FC4B File Offset: 0x0016DE4B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimpleMemberReference(Pointer, MemoryOwner);
		}

		// Token: 0x04008651 RID: 34385
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SimpleMemberReference";

		// Token: 0x04008652 RID: 34386
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008653 RID: 34387
		internal static int __PropertyOffset_MemberParent;

		// Token: 0x04008654 RID: 34388
		internal static int __PropertyOffset_MemberName;

		// Token: 0x04008655 RID: 34389
		internal static int __PropertyOffset_MemberGuid;
	}
}
