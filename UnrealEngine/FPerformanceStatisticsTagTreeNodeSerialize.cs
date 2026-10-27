using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200192D RID: 6445
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsTagTreeNodeSerialize")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FPerformanceStatisticsTagTreeNodeSerialize : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E56 RID: 97878 RVA: 0x002304F8 File Offset: 0x0022E6F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsTagTreeNodeSerialize._ScriptStructPtr != 0) ? FPerformanceStatisticsTagTreeNodeSerialize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsTagTreeNodeSerialize", ref FPerformanceStatisticsTagTreeNodeSerialize._ScriptStructPtr);
		}

		// Token: 0x17005FE4 RID: 24548
		// (get) Token: 0x06017E57 RID: 97879 RVA: 0x0023051C File Offset: 0x0022E71C
		// (set) Token: 0x06017E58 RID: 97880 RVA: 0x00230530 File Offset: 0x0022E730
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17005FE5 RID: 24549
		// (get) Token: 0x06017E59 RID: 97881 RVA: 0x00230545 File Offset: 0x0022E745
		// (set) Token: 0x06017E5A RID: 97882 RVA: 0x00230555 File Offset: 0x0022E755
		public unsafe float AverageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_AverageTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_AverageTime) = value;
			}
		}

		// Token: 0x17005FE6 RID: 24550
		// (get) Token: 0x06017E5B RID: 97883 RVA: 0x00230566 File Offset: 0x0022E766
		// (set) Token: 0x06017E5C RID: 97884 RVA: 0x00230576 File Offset: 0x0022E776
		public unsafe float MaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_MaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_MaxTime) = value;
			}
		}

		// Token: 0x17005FE7 RID: 24551
		// (get) Token: 0x06017E5D RID: 97885 RVA: 0x00230587 File Offset: 0x0022E787
		// (set) Token: 0x06017E5E RID: 97886 RVA: 0x00230597 File Offset: 0x0022E797
		public unsafe int Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_Mode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_Mode) = value;
			}
		}

		// Token: 0x17005FE8 RID: 24552
		// (get) Token: 0x06017E5F RID: 97887 RVA: 0x002305A8 File Offset: 0x0022E7A8
		// (set) Token: 0x06017E60 RID: 97888 RVA: 0x002305BC File Offset: 0x0022E7BC
		public unsafe string UserDefineMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_UserDefineMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPerformanceStatisticsTagTreeNodeSerialize.__PropertyOffset_UserDefineMessage)), value);
			}
		}

		// Token: 0x06017E61 RID: 97889 RVA: 0x002305D1 File Offset: 0x0022E7D1
		public FPerformanceStatisticsTagTreeNodeSerialize()
		{
		}

		// Token: 0x06017E62 RID: 97890 RVA: 0x002305D9 File Offset: 0x0022E7D9
		public FPerformanceStatisticsTagTreeNodeSerialize(FName Tag, float AverageTime, float MaxTime, int Mode, string UserDefineMessage)
		{
			this.Tag = Tag;
			this.AverageTime = AverageTime;
			this.MaxTime = MaxTime;
			this.Mode = Mode;
			this.UserDefineMessage = UserDefineMessage;
		}

		// Token: 0x06017E63 RID: 97891 RVA: 0x00230606 File Offset: 0x0022E806
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsTagTreeNodeSerialize.StaticStruct();
		}

		// Token: 0x06017E64 RID: 97892 RVA: 0x00230612 File Offset: 0x0022E812
		[NullableContext(2)]
		public FPerformanceStatisticsTagTreeNodeSerialize(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E65 RID: 97893 RVA: 0x0023061C File Offset: 0x0022E81C
		public FPerformanceStatisticsTagTreeNodeSerialize(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E66 RID: 97894 RVA: 0x00230627 File Offset: 0x0022E827
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsTagTreeNodeSerialize(Pointer, false, true);
		}

		// Token: 0x06017E67 RID: 97895 RVA: 0x00230631 File Offset: 0x0022E831
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsTagTreeNodeSerialize(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF0D RID: 53005
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsTagTreeNodeSerialize";

		// Token: 0x0400CF0E RID: 53006
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF0F RID: 53007
		internal static int __PropertyOffset_Tag;

		// Token: 0x0400CF10 RID: 53008
		internal static int __PropertyOffset_AverageTime;

		// Token: 0x0400CF11 RID: 53009
		internal static int __PropertyOffset_MaxTime;

		// Token: 0x0400CF12 RID: 53010
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400CF13 RID: 53011
		internal static int __PropertyOffset_UserDefineMessage;
	}
}
