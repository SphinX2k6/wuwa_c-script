using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D7F RID: 7551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Stack")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public abstract class UKSC_DA_Buff_Stack : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CEAB RID: 118443 RVA: 0x002ABE31 File Offset: 0x002AA031
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Stack._ClassPtr;
		}

		// Token: 0x1700749C RID: 29852
		// (get) Token: 0x0601CEAC RID: 118444 RVA: 0x002ABE3D File Offset: 0x002AA03D
		// (set) Token: 0x0601CEAD RID: 118445 RVA: 0x002ABE4D File Offset: 0x002AA04D
		public unsafe int StackNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackNum) = value;
			}
		}

		// Token: 0x1700749D RID: 29853
		// (get) Token: 0x0601CEAE RID: 118446 RVA: 0x002ABE5E File Offset: 0x002AA05E
		// (set) Token: 0x0601CEAF RID: 118447 RVA: 0x002ABE6E File Offset: 0x002AA06E
		public unsafe bool StackOverflowRemoveSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackOverflowRemoveSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackOverflowRemoveSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700749E RID: 29854
		// (get) Token: 0x0601CEB0 RID: 118448 RVA: 0x002ABE80 File Offset: 0x002AA080
		// (set) Token: 0x0601CEB1 RID: 118449 RVA: 0x002ABEB9 File Offset: 0x002AA0B9
		public TArray<UKSC_DA_Buff> StackOverflowBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DA_Buff> result;
				if ((result = this._StackOverflowBuffs) == null)
				{
					result = (this._StackOverflowBuffs = new TArray<UKSC_DA_Buff>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackOverflowBuffs, this));
				}
				return result;
			}
			set
			{
				this.StackOverflowBuffs.CopyAssign(value);
			}
		}

		// Token: 0x1700749F RID: 29855
		// (get) Token: 0x0601CEB2 RID: 118450 RVA: 0x002ABEC7 File Offset: 0x002AA0C7
		// (set) Token: 0x0601CEB3 RID: 118451 RVA: 0x002ABED7 File Offset: 0x002AA0D7
		public unsafe bool MultiStackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_MultiStackTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_MultiStackTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074A0 RID: 29856
		// (get) Token: 0x0601CEB4 RID: 118452 RVA: 0x002ABEE8 File Offset: 0x002AA0E8
		// (set) Token: 0x0601CEB5 RID: 118453 RVA: 0x002ABEF8 File Offset: 0x002AA0F8
		public unsafe bool OneSourceOneStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_OneSourceOneStack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_OneSourceOneStack) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074A1 RID: 29857
		// (get) Token: 0x0601CEB6 RID: 118454 RVA: 0x002ABF09 File Offset: 0x002AA109
		// (set) Token: 0x0601CEB7 RID: 118455 RVA: 0x002ABF19 File Offset: 0x002AA119
		public unsafe bool UseStackTimeType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_UseStackTimeType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_UseStackTimeType) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074A2 RID: 29858
		// (get) Token: 0x0601CEB8 RID: 118456 RVA: 0x002ABF2A File Offset: 0x002AA12A
		// (set) Token: 0x0601CEB9 RID: 118457 RVA: 0x002ABF3A File Offset: 0x002AA13A
		public unsafe EKSC_Buff_StackTimeType StackTimeType
		{
			get
			{
				return (EKSC_Buff_StackTimeType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackTimeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_StackTimeType) = (byte)value;
			}
		}

		// Token: 0x170074A3 RID: 29859
		// (get) Token: 0x0601CEBA RID: 118458 RVA: 0x002ABF4B File Offset: 0x002AA14B
		// (set) Token: 0x0601CEBB RID: 118459 RVA: 0x002ABF5B File Offset: 0x002AA15B
		public unsafe bool ChangeTagCountByStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_ChangeTagCountByStack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack.__PropertyOffset_ChangeTagCountByStack) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CEBC RID: 118460 RVA: 0x002ABF6C File Offset: 0x002AA16C
		static UKSC_DA_Buff_Stack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Stack");
		}

		// Token: 0x0601CEBD RID: 118461 RVA: 0x002ABF7C File Offset: 0x002AA17C
		protected UKSC_DA_Buff_Stack() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Stack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CEBE RID: 118462 RVA: 0x002ABFA4 File Offset: 0x002AA1A4
		protected UKSC_DA_Buff_Stack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB0F RID: 64271
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Stack";

		// Token: 0x0400FB10 RID: 64272
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB11 RID: 64273
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB12 RID: 64274
		internal static int __PropertyOffset_StackNum;

		// Token: 0x0400FB13 RID: 64275
		internal static int __PropertyOffset_StackOverflowRemoveSelf;

		// Token: 0x0400FB14 RID: 64276
		internal static int __PropertyOffset_StackOverflowBuffs;

		// Token: 0x0400FB15 RID: 64277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DA_Buff> _StackOverflowBuffs;

		// Token: 0x0400FB16 RID: 64278
		internal static int __PropertyOffset_MultiStackTime;

		// Token: 0x0400FB17 RID: 64279
		internal static int __PropertyOffset_OneSourceOneStack;

		// Token: 0x0400FB18 RID: 64280
		internal static int __PropertyOffset_UseStackTimeType;

		// Token: 0x0400FB19 RID: 64281
		internal static int __PropertyOffset_StackTimeType;

		// Token: 0x0400FB1A RID: 64282
		internal static int __PropertyOffset_ChangeTagCountByStack;
	}
}
