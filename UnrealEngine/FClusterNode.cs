using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200093D RID: 2365
	[UnrealObjectPath("/Script/Engine.ClusterNode")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FClusterNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060085AF RID: 34223 RVA: 0x000BE9F7 File Offset: 0x000BCBF7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClusterNode._ScriptStructPtr != 0) ? FClusterNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClusterNode", ref FClusterNode._ScriptStructPtr);
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x060085B0 RID: 34224 RVA: 0x000BEA1B File Offset: 0x000BCC1B
		// (set) Token: 0x060085B1 RID: 34225 RVA: 0x000BEA2F File Offset: 0x000BCC2F
		public unsafe FVector BoundMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_BoundMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_BoundMin) = value;
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x060085B2 RID: 34226 RVA: 0x000BEA44 File Offset: 0x000BCC44
		// (set) Token: 0x060085B3 RID: 34227 RVA: 0x000BEA54 File Offset: 0x000BCC54
		public unsafe int FirstChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_FirstChild);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_FirstChild) = value;
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x060085B4 RID: 34228 RVA: 0x000BEA65 File Offset: 0x000BCC65
		// (set) Token: 0x060085B5 RID: 34229 RVA: 0x000BEA79 File Offset: 0x000BCC79
		public unsafe FVector BoundMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_BoundMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_BoundMax) = value;
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x060085B6 RID: 34230 RVA: 0x000BEA8E File Offset: 0x000BCC8E
		// (set) Token: 0x060085B7 RID: 34231 RVA: 0x000BEA9E File Offset: 0x000BCC9E
		public unsafe int LastChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_LastChild);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_LastChild) = value;
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x060085B8 RID: 34232 RVA: 0x000BEAAF File Offset: 0x000BCCAF
		// (set) Token: 0x060085B9 RID: 34233 RVA: 0x000BEABF File Offset: 0x000BCCBF
		public unsafe int FirstInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_FirstInstance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_FirstInstance) = value;
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x060085BA RID: 34234 RVA: 0x000BEAD0 File Offset: 0x000BCCD0
		// (set) Token: 0x060085BB RID: 34235 RVA: 0x000BEAE0 File Offset: 0x000BCCE0
		public unsafe int LastInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_LastInstance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_LastInstance) = value;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x060085BC RID: 34236 RVA: 0x000BEAF1 File Offset: 0x000BCCF1
		// (set) Token: 0x060085BD RID: 34237 RVA: 0x000BEB05 File Offset: 0x000BCD05
		public unsafe FVector MinInstanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_MinInstanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_MinInstanceScale) = value;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x060085BE RID: 34238 RVA: 0x000BEB1A File Offset: 0x000BCD1A
		// (set) Token: 0x060085BF RID: 34239 RVA: 0x000BEB2E File Offset: 0x000BCD2E
		public unsafe FVector MaxInstanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_MaxInstanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClusterNode.__PropertyOffset_MaxInstanceScale) = value;
			}
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x000BEB43 File Offset: 0x000BCD43
		public FClusterNode()
		{
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x000BEB4C File Offset: 0x000BCD4C
		public FClusterNode(FVector BoundMin, int FirstChild, FVector BoundMax, int LastChild, int FirstInstance, int LastInstance, FVector MinInstanceScale, FVector MaxInstanceScale)
		{
			this.BoundMin = BoundMin;
			this.FirstChild = FirstChild;
			this.BoundMax = BoundMax;
			this.LastChild = LastChild;
			this.FirstInstance = FirstInstance;
			this.LastInstance = LastInstance;
			this.MinInstanceScale = MinInstanceScale;
			this.MaxInstanceScale = MaxInstanceScale;
		}

		// Token: 0x060085C2 RID: 34242 RVA: 0x000BEB9C File Offset: 0x000BCD9C
		protected override IntPtr GetUStructPtr()
		{
			return FClusterNode.StaticStruct();
		}

		// Token: 0x060085C3 RID: 34243 RVA: 0x000BEBA8 File Offset: 0x000BCDA8
		[NullableContext(2)]
		public FClusterNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060085C4 RID: 34244 RVA: 0x000BEBB2 File Offset: 0x000BCDB2
		public FClusterNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060085C5 RID: 34245 RVA: 0x000BEBBD File Offset: 0x000BCDBD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClusterNode(Pointer, false, true);
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x000BEBC7 File Offset: 0x000BCDC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClusterNode(Pointer, MemoryOwner);
		}

		// Token: 0x04003FA0 RID: 16288
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ClusterNode";

		// Token: 0x04003FA1 RID: 16289
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FA2 RID: 16290
		internal static int __PropertyOffset_BoundMin;

		// Token: 0x04003FA3 RID: 16291
		internal static int __PropertyOffset_FirstChild;

		// Token: 0x04003FA4 RID: 16292
		internal static int __PropertyOffset_BoundMax;

		// Token: 0x04003FA5 RID: 16293
		internal static int __PropertyOffset_LastChild;

		// Token: 0x04003FA6 RID: 16294
		internal static int __PropertyOffset_FirstInstance;

		// Token: 0x04003FA7 RID: 16295
		internal static int __PropertyOffset_LastInstance;

		// Token: 0x04003FA8 RID: 16296
		internal static int __PropertyOffset_MinInstanceScale;

		// Token: 0x04003FA9 RID: 16297
		internal static int __PropertyOffset_MaxInstanceScale;
	}
}
