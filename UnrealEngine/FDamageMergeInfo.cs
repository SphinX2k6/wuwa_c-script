using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200187F RID: 6271
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.DamageMergeInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FDamageMergeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060171AA RID: 94634 RVA: 0x0021ABA4 File Offset: 0x00218DA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDamageMergeInfo._ScriptStructPtr != 0) ? FDamageMergeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplayUI.DamageMergeInfo", ref FDamageMergeInfo._ScriptStructPtr);
		}

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x060171AB RID: 94635 RVA: 0x0021ABC8 File Offset: 0x00218DC8
		// (set) Token: 0x060171AC RID: 94636 RVA: 0x0021AC0B File Offset: 0x00218E0B
		public FDamageInfo DamageInfo
		{
			get
			{
				base.FastCheckIsValid();
				FDamageInfo result;
				if ((result = this._DamageInfo) == null)
				{
					result = (this._DamageInfo = new FDamageInfo(base.NativePtr + (IntPtr)FDamageMergeInfo.__PropertyOffset_DamageInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDamageInfo.StaticStruct(), base.NativePtr + (IntPtr)FDamageMergeInfo.__PropertyOffset_DamageInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005CF8 RID: 23800
		// (get) Token: 0x060171AD RID: 94637 RVA: 0x0021AC2C File Offset: 0x00218E2C
		// (set) Token: 0x060171AE RID: 94638 RVA: 0x0021AC3C File Offset: 0x00218E3C
		public unsafe float ShowDamageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDamageMergeInfo.__PropertyOffset_ShowDamageTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDamageMergeInfo.__PropertyOffset_ShowDamageTime) = value;
			}
		}

		// Token: 0x060171AF RID: 94639 RVA: 0x0021AC4D File Offset: 0x00218E4D
		public FDamageMergeInfo()
		{
		}

		// Token: 0x060171B0 RID: 94640 RVA: 0x0021AC55 File Offset: 0x00218E55
		public FDamageMergeInfo(FDamageInfo DamageInfo, float ShowDamageTime)
		{
			this.DamageInfo = DamageInfo;
			this.ShowDamageTime = ShowDamageTime;
		}

		// Token: 0x060171B1 RID: 94641 RVA: 0x0021AC6B File Offset: 0x00218E6B
		protected override IntPtr GetUStructPtr()
		{
			return FDamageMergeInfo.StaticStruct();
		}

		// Token: 0x060171B2 RID: 94642 RVA: 0x0021AC77 File Offset: 0x00218E77
		[NullableContext(2)]
		public FDamageMergeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060171B3 RID: 94643 RVA: 0x0021AC81 File Offset: 0x00218E81
		public FDamageMergeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060171B4 RID: 94644 RVA: 0x0021AC8C File Offset: 0x00218E8C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDamageMergeInfo(Pointer, false, true);
		}

		// Token: 0x060171B5 RID: 94645 RVA: 0x0021AC96 File Offset: 0x00218E96
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDamageMergeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400C890 RID: 51344
		public const string __ObjectPath = "/Script/KuroGameplayUI.DamageMergeInfo";

		// Token: 0x0400C891 RID: 51345
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C892 RID: 51346
		internal static int __PropertyOffset_DamageInfo;

		// Token: 0x0400C893 RID: 51347
		[Nullable(2)]
		private FDamageInfo _DamageInfo;

		// Token: 0x0400C894 RID: 51348
		internal static int __PropertyOffset_ShowDamageTime;
	}
}
