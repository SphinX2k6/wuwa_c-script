using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003EA RID: 1002
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSpecData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectSpecData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006207 RID: 25095 RVA: 0x0008C2C1 File Offset: 0x0008A4C1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectSpecData._ScriptStructPtr != 0) ? FKuroEffectSpecData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectSpecData", ref FKuroEffectSpecData._ScriptStructPtr);
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06006208 RID: 25096 RVA: 0x0008C2E5 File Offset: 0x0008A4E5
		// (set) Token: 0x06006209 RID: 25097 RVA: 0x0008C2F5 File Offset: 0x0008A4F5
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x0600620A RID: 25098 RVA: 0x0008C306 File Offset: 0x0008A506
		// (set) Token: 0x0600620B RID: 25099 RVA: 0x0008C316 File Offset: 0x0008A516
		public unsafe byte SpecType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_SpecType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_SpecType) = value;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x0600620C RID: 25100 RVA: 0x0008C327 File Offset: 0x0008A527
		// (set) Token: 0x0600620D RID: 25101 RVA: 0x0008C337 File Offset: 0x0008A537
		public unsafe byte EffectRegularType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_EffectRegularType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_EffectRegularType) = value;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x0600620E RID: 25102 RVA: 0x0008C348 File Offset: 0x0008A548
		// (set) Token: 0x0600620F RID: 25103 RVA: 0x0008C358 File Offset: 0x0008A558
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_LifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectSpecData.__PropertyOffset_LifeTime) = value;
			}
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x0008C369 File Offset: 0x0008A569
		public FKuroEffectSpecData()
		{
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x0008C371 File Offset: 0x0008A571
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectSpecData.StaticStruct();
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x0008C37D File Offset: 0x0008A57D
		[NullableContext(2)]
		public FKuroEffectSpecData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x0008C387 File Offset: 0x0008A587
		public FKuroEffectSpecData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x0008C392 File Offset: 0x0008A592
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectSpecData(Pointer, false, true);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x0008C39C File Offset: 0x0008A59C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectSpecData(Pointer, MemoryOwner);
		}

		// Token: 0x040029BF RID: 10687
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSpecData";

		// Token: 0x040029C0 RID: 10688
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029C1 RID: 10689
		internal static int __PropertyOffset_Id;

		// Token: 0x040029C2 RID: 10690
		internal static int __PropertyOffset_SpecType;

		// Token: 0x040029C3 RID: 10691
		internal static int __PropertyOffset_EffectRegularType;

		// Token: 0x040029C4 RID: 10692
		internal static int __PropertyOffset_LifeTime;
	}
}
