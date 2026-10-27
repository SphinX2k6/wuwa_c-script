using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018D0 RID: 6352
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSpecData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectSpecData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017801 RID: 96257 RVA: 0x00226837 File Offset: 0x00224A37
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectSpecData._ScriptStructPtr != 0) ? FKuroEffectSpecData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectSpecData", ref FKuroEffectSpecData._ScriptStructPtr);
		}

		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x06017802 RID: 96258 RVA: 0x0022685B File Offset: 0x00224A5B
		// (set) Token: 0x06017803 RID: 96259 RVA: 0x0022686B File Offset: 0x00224A6B
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

		// Token: 0x17005EE8 RID: 24296
		// (get) Token: 0x06017804 RID: 96260 RVA: 0x0022687C File Offset: 0x00224A7C
		// (set) Token: 0x06017805 RID: 96261 RVA: 0x0022688C File Offset: 0x00224A8C
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

		// Token: 0x17005EE9 RID: 24297
		// (get) Token: 0x06017806 RID: 96262 RVA: 0x0022689D File Offset: 0x00224A9D
		// (set) Token: 0x06017807 RID: 96263 RVA: 0x002268AD File Offset: 0x00224AAD
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

		// Token: 0x17005EEA RID: 24298
		// (get) Token: 0x06017808 RID: 96264 RVA: 0x002268BE File Offset: 0x00224ABE
		// (set) Token: 0x06017809 RID: 96265 RVA: 0x002268CE File Offset: 0x00224ACE
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

		// Token: 0x0601780A RID: 96266 RVA: 0x002268DF File Offset: 0x00224ADF
		public FKuroEffectSpecData()
		{
		}

		// Token: 0x0601780B RID: 96267 RVA: 0x002268E7 File Offset: 0x00224AE7
		public FKuroEffectSpecData(int Id, FName Path, byte SpecType, byte EffectRegularType, float LifeTime)
		{
			this.Id = Id;
			this.SpecType = SpecType;
			this.EffectRegularType = EffectRegularType;
			this.LifeTime = LifeTime;
		}

		// Token: 0x0601780C RID: 96268 RVA: 0x0022690D File Offset: 0x00224B0D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectSpecData.StaticStruct();
		}

		// Token: 0x0601780D RID: 96269 RVA: 0x00226919 File Offset: 0x00224B19
		[NullableContext(2)]
		public FKuroEffectSpecData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601780E RID: 96270 RVA: 0x00226923 File Offset: 0x00224B23
		public FKuroEffectSpecData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601780F RID: 96271 RVA: 0x0022692E File Offset: 0x00224B2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectSpecData(Pointer, false, true);
		}

		// Token: 0x06017810 RID: 96272 RVA: 0x00226938 File Offset: 0x00224B38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectSpecData(Pointer, MemoryOwner);
		}

		// Token: 0x0400CC86 RID: 52358
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSpecData";

		// Token: 0x0400CC87 RID: 52359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CC88 RID: 52360
		internal static int __PropertyOffset_Id;

		// Token: 0x0400CC89 RID: 52361
		internal static int __PropertyOffset_SpecType;

		// Token: 0x0400CC8A RID: 52362
		internal static int __PropertyOffset_EffectRegularType;

		// Token: 0x0400CC8B RID: 52363
		internal static int __PropertyOffset_LifeTime;
	}
}
