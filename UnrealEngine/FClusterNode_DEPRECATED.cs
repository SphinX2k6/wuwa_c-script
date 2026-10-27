using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200093E RID: 2366
	[UnrealObjectPath("/Script/Engine.ClusterNode_DEPRECATED")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FClusterNode_DEPRECATED : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060085C7 RID: 34247 RVA: 0x000BEBD0 File Offset: 0x000BCDD0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClusterNode_DEPRECATED._ScriptStructPtr != 0) ? FClusterNode_DEPRECATED._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClusterNode_DEPRECATED", ref FClusterNode_DEPRECATED._ScriptStructPtr);
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x060085C8 RID: 34248 RVA: 0x000BEBF4 File Offset: 0x000BCDF4
		// (set) Token: 0x060085C9 RID: 34249 RVA: 0x000BEC08 File Offset: 0x000BCE08
		public unsafe FVector BoundMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_BoundMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_BoundMin) = value;
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x060085CA RID: 34250 RVA: 0x000BEC1D File Offset: 0x000BCE1D
		// (set) Token: 0x060085CB RID: 34251 RVA: 0x000BEC2D File Offset: 0x000BCE2D
		public unsafe int FirstChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_FirstChild);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_FirstChild) = value;
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x060085CC RID: 34252 RVA: 0x000BEC3E File Offset: 0x000BCE3E
		// (set) Token: 0x060085CD RID: 34253 RVA: 0x000BEC52 File Offset: 0x000BCE52
		public unsafe FVector BoundMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_BoundMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_BoundMax) = value;
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x060085CE RID: 34254 RVA: 0x000BEC67 File Offset: 0x000BCE67
		// (set) Token: 0x060085CF RID: 34255 RVA: 0x000BEC77 File Offset: 0x000BCE77
		public unsafe int LastChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_LastChild);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_LastChild) = value;
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x060085D0 RID: 34256 RVA: 0x000BEC88 File Offset: 0x000BCE88
		// (set) Token: 0x060085D1 RID: 34257 RVA: 0x000BEC98 File Offset: 0x000BCE98
		public unsafe int FirstInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_FirstInstance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_FirstInstance) = value;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x060085D2 RID: 34258 RVA: 0x000BECA9 File Offset: 0x000BCEA9
		// (set) Token: 0x060085D3 RID: 34259 RVA: 0x000BECB9 File Offset: 0x000BCEB9
		public unsafe int LastInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_LastInstance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode_DEPRECATED.__PropertyOffset_LastInstance) = value;
			}
		}

		// Token: 0x060085D4 RID: 34260 RVA: 0x000BECCA File Offset: 0x000BCECA
		public FClusterNode_DEPRECATED()
		{
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x000BECD2 File Offset: 0x000BCED2
		public FClusterNode_DEPRECATED(FVector BoundMin, int FirstChild, FVector BoundMax, int LastChild, int FirstInstance, int LastInstance)
		{
			this.BoundMin = BoundMin;
			this.FirstChild = FirstChild;
			this.BoundMax = BoundMax;
			this.LastChild = LastChild;
			this.FirstInstance = FirstInstance;
			this.LastInstance = LastInstance;
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x000BED07 File Offset: 0x000BCF07
		protected override IntPtr GetUStructPtr()
		{
			return FClusterNode_DEPRECATED.StaticStruct();
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x000BED13 File Offset: 0x000BCF13
		[NullableContext(2)]
		public FClusterNode_DEPRECATED(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x000BED1D File Offset: 0x000BCF1D
		public FClusterNode_DEPRECATED(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x000BED28 File Offset: 0x000BCF28
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClusterNode_DEPRECATED(Pointer, false, true);
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x000BED32 File Offset: 0x000BCF32
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClusterNode_DEPRECATED(Pointer, MemoryOwner);
		}

		// Token: 0x04003FAA RID: 16298
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ClusterNode_DEPRECATED";

		// Token: 0x04003FAB RID: 16299
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FAC RID: 16300
		internal static int __PropertyOffset_BoundMin;

		// Token: 0x04003FAD RID: 16301
		internal static int __PropertyOffset_FirstChild;

		// Token: 0x04003FAE RID: 16302
		internal static int __PropertyOffset_BoundMax;

		// Token: 0x04003FAF RID: 16303
		internal static int __PropertyOffset_LastChild;

		// Token: 0x04003FB0 RID: 16304
		internal static int __PropertyOffset_FirstInstance;

		// Token: 0x04003FB1 RID: 16305
		internal static int __PropertyOffset_LastInstance;
	}
}
