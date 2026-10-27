using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200192E RID: 6446
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsTagTreeSerialize")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPerformanceStatisticsTagTreeSerialize : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E68 RID: 97896 RVA: 0x0023063A File Offset: 0x0022E83A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsTagTreeSerialize._ScriptStructPtr != 0) ? FPerformanceStatisticsTagTreeSerialize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsTagTreeSerialize", ref FPerformanceStatisticsTagTreeSerialize._ScriptStructPtr);
		}

		// Token: 0x17005FE9 RID: 24553
		// (get) Token: 0x06017E69 RID: 97897 RVA: 0x00230660 File Offset: 0x0022E860
		// (set) Token: 0x06017E6A RID: 97898 RVA: 0x002306A3 File Offset: 0x0022E8A3
		public FPerformanceStatisticsTagTreeNodeSerialize NodeSerialize
		{
			get
			{
				base.FastCheckIsValid();
				FPerformanceStatisticsTagTreeNodeSerialize result;
				if ((result = this._NodeSerialize) == null)
				{
					result = (this._NodeSerialize = new FPerformanceStatisticsTagTreeNodeSerialize(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeSerialize.__PropertyOffset_NodeSerialize, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerformanceStatisticsTagTreeNodeSerialize.StaticStruct(), base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeSerialize.__PropertyOffset_NodeSerialize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005FEA RID: 24554
		// (get) Token: 0x06017E6B RID: 97899 RVA: 0x002306C4 File Offset: 0x0022E8C4
		// (set) Token: 0x06017E6C RID: 97900 RVA: 0x00230707 File Offset: 0x0022E907
		public TArray<FPerformanceStatisticsTagTreeNodeSerialize> ChildTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerformanceStatisticsTagTreeNodeSerialize> result;
				if ((result = this._ChildTags) == null)
				{
					result = (this._ChildTags = new TArray<FPerformanceStatisticsTagTreeNodeSerialize>(base.NativePtr + (IntPtr)FPerformanceStatisticsTagTreeSerialize.__PropertyOffset_ChildTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildTags.CopyAssign(value);
			}
		}

		// Token: 0x06017E6D RID: 97901 RVA: 0x00230715 File Offset: 0x0022E915
		public FPerformanceStatisticsTagTreeSerialize()
		{
		}

		// Token: 0x06017E6E RID: 97902 RVA: 0x0023071D File Offset: 0x0022E91D
		public FPerformanceStatisticsTagTreeSerialize(FPerformanceStatisticsTagTreeNodeSerialize NodeSerialize, TArray<FPerformanceStatisticsTagTreeNodeSerialize> ChildTags)
		{
			this.NodeSerialize = NodeSerialize;
			this.ChildTags = ChildTags;
		}

		// Token: 0x06017E6F RID: 97903 RVA: 0x00230733 File Offset: 0x0022E933
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsTagTreeSerialize.StaticStruct();
		}

		// Token: 0x06017E70 RID: 97904 RVA: 0x0023073F File Offset: 0x0022E93F
		[NullableContext(2)]
		public FPerformanceStatisticsTagTreeSerialize(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E71 RID: 97905 RVA: 0x00230749 File Offset: 0x0022E949
		public FPerformanceStatisticsTagTreeSerialize(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E72 RID: 97906 RVA: 0x00230754 File Offset: 0x0022E954
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsTagTreeSerialize(Pointer, false, true);
		}

		// Token: 0x06017E73 RID: 97907 RVA: 0x0023075E File Offset: 0x0022E95E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsTagTreeSerialize(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF14 RID: 53012
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsTagTreeSerialize";

		// Token: 0x0400CF15 RID: 53013
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF16 RID: 53014
		internal static int __PropertyOffset_NodeSerialize;

		// Token: 0x0400CF17 RID: 53015
		[Nullable(2)]
		private FPerformanceStatisticsTagTreeNodeSerialize _NodeSerialize;

		// Token: 0x0400CF18 RID: 53016
		internal static int __PropertyOffset_ChildTags;

		// Token: 0x0400CF19 RID: 53017
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerformanceStatisticsTagTreeNodeSerialize> _ChildTags;
	}
}
