using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EA1 RID: 3745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshCastShadowCheck")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMeshCastShadowCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CA2D RID: 51757 RVA: 0x00126718 File Offset: 0x00124918
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshCastShadowCheck._ScriptStructPtr != 0) ? FMeshCastShadowCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshCastShadowCheck", ref FMeshCastShadowCheck._ScriptStructPtr);
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600CA2E RID: 51758 RVA: 0x0012673C File Offset: 0x0012493C
		// (set) Token: 0x0600CA2F RID: 51759 RVA: 0x0012677F File Offset: 0x0012497F
		public TArray<string> SpecifiedClassName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SpecifiedClassName) == null)
				{
					result = (this._SpecifiedClassName = new TArray<string>(base.NativePtr + (IntPtr)FMeshCastShadowCheck.__PropertyOffset_SpecifiedClassName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecifiedClassName.CopyAssign(value);
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x0012678D File Offset: 0x0012498D
		// (set) Token: 0x0600CA31 RID: 51761 RVA: 0x0012679D File Offset: 0x0012499D
		public unsafe int StaticMeshNeedShadowProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshCastShadowCheck.__PropertyOffset_StaticMeshNeedShadowProxy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshCastShadowCheck.__PropertyOffset_StaticMeshNeedShadowProxy) = value;
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600CA32 RID: 51762 RVA: 0x001267AE File Offset: 0x001249AE
		// (set) Token: 0x0600CA33 RID: 51763 RVA: 0x001267BE File Offset: 0x001249BE
		public unsafe int StaticMeshShadowProxyTriRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshCastShadowCheck.__PropertyOffset_StaticMeshShadowProxyTriRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshCastShadowCheck.__PropertyOffset_StaticMeshShadowProxyTriRate) = value;
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600CA34 RID: 51764 RVA: 0x001267D0 File Offset: 0x001249D0
		// (set) Token: 0x0600CA35 RID: 51765 RVA: 0x00126813 File Offset: 0x00124A13
		public TArray<string> SSRProxyMeshTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SSRProxyMeshTags) == null)
				{
					result = (this._SSRProxyMeshTags = new TArray<string>(base.NativePtr + (IntPtr)FMeshCastShadowCheck.__PropertyOffset_SSRProxyMeshTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SSRProxyMeshTags.CopyAssign(value);
			}
		}

		// Token: 0x0600CA36 RID: 51766 RVA: 0x00126821 File Offset: 0x00124A21
		public FMeshCastShadowCheck()
		{
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x00126829 File Offset: 0x00124A29
		public FMeshCastShadowCheck(TArray<string> SpecifiedClassName, int StaticMeshNeedShadowProxy, int StaticMeshShadowProxyTriRate, TArray<string> SSRProxyMeshTags)
		{
			this.SpecifiedClassName = SpecifiedClassName;
			this.StaticMeshNeedShadowProxy = StaticMeshNeedShadowProxy;
			this.StaticMeshShadowProxyTriRate = StaticMeshShadowProxyTriRate;
			this.SSRProxyMeshTags = SSRProxyMeshTags;
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x0012684E File Offset: 0x00124A4E
		protected override IntPtr GetUStructPtr()
		{
			return FMeshCastShadowCheck.StaticStruct();
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x0012685A File Offset: 0x00124A5A
		[NullableContext(2)]
		public FMeshCastShadowCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x00126864 File Offset: 0x00124A64
		public FMeshCastShadowCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x0012686F File Offset: 0x00124A6F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshCastShadowCheck(Pointer, false, true);
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x00126879 File Offset: 0x00124A79
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshCastShadowCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04006CDC RID: 27868
		public const string __ObjectPath = "/Script/Engine.MeshCastShadowCheck";

		// Token: 0x04006CDD RID: 27869
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006CDE RID: 27870
		internal static int __PropertyOffset_SpecifiedClassName;

		// Token: 0x04006CDF RID: 27871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SpecifiedClassName;

		// Token: 0x04006CE0 RID: 27872
		internal static int __PropertyOffset_StaticMeshNeedShadowProxy;

		// Token: 0x04006CE1 RID: 27873
		internal static int __PropertyOffset_StaticMeshShadowProxyTriRate;

		// Token: 0x04006CE2 RID: 27874
		internal static int __PropertyOffset_SSRProxyMeshTags;

		// Token: 0x04006CE3 RID: 27875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SSRProxyMeshTags;
	}
}
