using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200089E RID: 2206
	[UnrealObjectPath("/Script/Engine.BakingSwitches")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FBakingSwitches : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078B8 RID: 30904 RVA: 0x000ACDCA File Offset: 0x000AAFCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakingSwitches._ScriptStructPtr != 0) ? FBakingSwitches._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakingSwitches", ref FBakingSwitches._ScriptStructPtr);
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x060078B9 RID: 30905 RVA: 0x000ACDEE File Offset: 0x000AAFEE
		// (set) Token: 0x060078BA RID: 30906 RVA: 0x000ACE07 File Offset: 0x000AB007
		public unsafe bool bUseLightmass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBakingSwitches.__PropertyOffset_bUseLightmass) & FBakingSwitches.__PropertyMask_bUseLightmass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBakingSwitches.__PropertyOffset_bUseLightmass) = ((*(base.NativePtr + (IntPtr)FBakingSwitches.__PropertyOffset_bUseLightmass) & ~FBakingSwitches.__PropertyMask_bUseLightmass) | (value ? FBakingSwitches.__PropertyMask_bUseLightmass : 0));
			}
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x000ACE37 File Offset: 0x000AB037
		public FBakingSwitches()
		{
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x000ACE3F File Offset: 0x000AB03F
		public FBakingSwitches(bool bUseLightmass)
		{
			this.bUseLightmass = bUseLightmass;
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x000ACE4E File Offset: 0x000AB04E
		protected override IntPtr GetUStructPtr()
		{
			return FBakingSwitches.StaticStruct();
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x000ACE5A File Offset: 0x000AB05A
		[NullableContext(2)]
		public FBakingSwitches(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x000ACE64 File Offset: 0x000AB064
		public FBakingSwitches(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x000ACE6F File Offset: 0x000AB06F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakingSwitches(Pointer, false, true);
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x000ACE79 File Offset: 0x000AB079
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakingSwitches(Pointer, MemoryOwner);
		}

		// Token: 0x040039FC RID: 14844
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BakingSwitches";

		// Token: 0x040039FD RID: 14845
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039FE RID: 14846
		internal static int __PropertyOffset_bUseLightmass;

		// Token: 0x040039FF RID: 14847
		internal static byte __PropertyMask_bUseLightmass;
	}
}
