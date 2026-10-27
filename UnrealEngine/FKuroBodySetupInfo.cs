using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001745 RID: 5957
	[UnrealObjectPath("/Script/KuroCollision.KuroBodySetupInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroBodySetupInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060156EE RID: 87790 RVA: 0x001F7F73 File Offset: 0x001F6173
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBodySetupInfo._ScriptStructPtr != 0) ? FKuroBodySetupInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCollision.KuroBodySetupInfo", ref FKuroBodySetupInfo._ScriptStructPtr);
		}

		// Token: 0x170054A3 RID: 21667
		// (get) Token: 0x060156EF RID: 87791 RVA: 0x001F7F97 File Offset: 0x001F6197
		// (set) Token: 0x060156F0 RID: 87792 RVA: 0x001F7FAB File Offset: 0x001F61AB
		[Nullable(2)]
		public unsafe UBodySetup BodySetup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBodySetupInfo.__PropertyOffset_BodySetup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBodySetupInfo.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x060156F1 RID: 87793 RVA: 0x001F7FC0 File Offset: 0x001F61C0
		public FKuroBodySetupInfo()
		{
		}

		// Token: 0x060156F2 RID: 87794 RVA: 0x001F7FC8 File Offset: 0x001F61C8
		[NullableContext(1)]
		public FKuroBodySetupInfo(UBodySetup BodySetup)
		{
			this.BodySetup = BodySetup;
		}

		// Token: 0x060156F3 RID: 87795 RVA: 0x001F7FD7 File Offset: 0x001F61D7
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBodySetupInfo.StaticStruct();
		}

		// Token: 0x060156F4 RID: 87796 RVA: 0x001F7FE3 File Offset: 0x001F61E3
		[NullableContext(2)]
		public FKuroBodySetupInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060156F5 RID: 87797 RVA: 0x001F7FED File Offset: 0x001F61ED
		public FKuroBodySetupInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060156F6 RID: 87798 RVA: 0x001F7FF8 File Offset: 0x001F61F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBodySetupInfo(Pointer, false, true);
		}

		// Token: 0x060156F7 RID: 87799 RVA: 0x001F8002 File Offset: 0x001F6202
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBodySetupInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400BAF9 RID: 47865
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCollision.KuroBodySetupInfo";

		// Token: 0x0400BAFA RID: 47866
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BAFB RID: 47867
		internal static int __PropertyOffset_BodySetup;
	}
}
