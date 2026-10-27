using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000134 RID: 308
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTCompositeNode")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public abstract class UBTCompositeNode : UBTNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015D3 RID: 5587 RVA: 0x000200CA File Offset: 0x0001E2CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTCompositeNode._ClassPtr;
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000200D8 File Offset: 0x0001E2D8
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x00020111 File Offset: 0x0001E311
		public TArray<FBTCompositeChild> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBTCompositeChild> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<FBTCompositeChild>(base.NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_Children, this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00020120 File Offset: 0x0001E320
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x00020159 File Offset: 0x0001E359
		public TArray<UBTService> Services
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTService> result;
				if ((result = this._Services) == null)
				{
					result = (this._Services = new TArray<UBTService>(base.NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_Services, this));
				}
				return result;
			}
			set
			{
				this.Services.CopyAssign(value);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00020167 File Offset: 0x0001E367
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x00020180 File Offset: 0x0001E380
		public unsafe bool bApplyDecoratorScope
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_bApplyDecoratorScope) & UBTCompositeNode.__PropertyMask_bApplyDecoratorScope) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_bApplyDecoratorScope) = ((*(base.NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_bApplyDecoratorScope) & ~UBTCompositeNode.__PropertyMask_bApplyDecoratorScope) | (value ? UBTCompositeNode.__PropertyMask_bApplyDecoratorScope : 0));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x000201B0 File Offset: 0x0001E3B0
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x000201C9 File Offset: 0x0001E3C9
		public unsafe bool bCanExecuteMulti
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_bCanExecuteMulti) & UBTCompositeNode.__PropertyMask_bCanExecuteMulti) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_bCanExecuteMulti) = ((*(base.NativePtr + (IntPtr)UBTCompositeNode.__PropertyOffset_bCanExecuteMulti) & ~UBTCompositeNode.__PropertyMask_bCanExecuteMulti) | (value ? UBTCompositeNode.__PropertyMask_bCanExecuteMulti : 0));
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000201F9 File Offset: 0x0001E3F9
		static UBTCompositeNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTCompositeNode");
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00020208 File Offset: 0x0001E408
		protected UBTCompositeNode() : this(BuiltinUtils.AllocNativeUObject(UBTCompositeNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00020230 File Offset: 0x0001E430
		protected UBTCompositeNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004BE RID: 1214
		public new const string __ObjectPath = "/Script/AIModule.BTCompositeNode";

		// Token: 0x040004BF RID: 1215
		private static IntPtr _ClassPtr;

		// Token: 0x040004C0 RID: 1216
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004C1 RID: 1217
		internal static int __PropertyOffset_Children;

		// Token: 0x040004C2 RID: 1218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBTCompositeChild> _Children;

		// Token: 0x040004C3 RID: 1219
		internal static int __PropertyOffset_Services;

		// Token: 0x040004C4 RID: 1220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTService> _Services;

		// Token: 0x040004C5 RID: 1221
		internal static int __PropertyOffset_bApplyDecoratorScope;

		// Token: 0x040004C6 RID: 1222
		internal static byte __PropertyMask_bApplyDecoratorScope;

		// Token: 0x040004C7 RID: 1223
		internal static int __PropertyOffset_bCanExecuteMulti;

		// Token: 0x040004C8 RID: 1224
		internal static byte __PropertyMask_bCanExecuteMulti;
	}
}
