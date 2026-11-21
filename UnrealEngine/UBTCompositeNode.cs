using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B0 RID: 176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTCompositeNode")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public abstract class UBTCompositeNode : UBTNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x00014FAD File Offset: 0x000131AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTCompositeNode._ClassPtr;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x00014FBC File Offset: 0x000131BC
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00014FF5 File Offset: 0x000131F5
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00015004 File Offset: 0x00013204
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x0001503D File Offset: 0x0001323D
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0001504B File Offset: 0x0001324B
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00015064 File Offset: 0x00013264
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00015094 File Offset: 0x00013294
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x000150AD File Offset: 0x000132AD
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

		// Token: 0x06000D4B RID: 3403 RVA: 0x000150DD File Offset: 0x000132DD
		static UBTCompositeNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTCompositeNode");
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000150EC File Offset: 0x000132EC
		protected UBTCompositeNode() : this(BuiltinUtils.AllocNativeUObject(UBTCompositeNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00015114 File Offset: 0x00013314
		protected UBTCompositeNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400024F RID: 591
		public new const string __ObjectPath = "/Script/AIModule.BTCompositeNode";

		// Token: 0x04000250 RID: 592
		private static IntPtr _ClassPtr;

		// Token: 0x04000251 RID: 593
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000252 RID: 594
		internal static int __PropertyOffset_Children;

		// Token: 0x04000253 RID: 595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBTCompositeChild> _Children;

		// Token: 0x04000254 RID: 596
		internal static int __PropertyOffset_Services;

		// Token: 0x04000255 RID: 597
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTService> _Services;

		// Token: 0x04000256 RID: 598
		internal static int __PropertyOffset_bApplyDecoratorScope;

		// Token: 0x04000257 RID: 599
		internal static byte __PropertyMask_bApplyDecoratorScope;

		// Token: 0x04000258 RID: 600
		internal static int __PropertyOffset_bCanExecuteMulti;

		// Token: 0x04000259 RID: 601
		internal static byte __PropertyMask_bCanExecuteMulti;
	}
}
