using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000133 RID: 307
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTCompositeChild")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FBTCompositeChild : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x0001FF4D File Offset: 0x0001E14D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBTCompositeChild._ScriptStructPtr != 0) ? FBTCompositeChild._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.BTCompositeChild", ref FBTCompositeChild._ScriptStructPtr);
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0001FF71 File Offset: 0x0001E171
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0001FF85 File Offset: 0x0001E185
		[Nullable(2)]
		public unsafe UBTCompositeNode ChildComposite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTCompositeNode>(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildComposite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildComposite, value);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0001FF9A File Offset: 0x0001E19A
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x0001FFAE File Offset: 0x0001E1AE
		[Nullable(2)]
		public unsafe UBTTaskNode ChildTask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTTaskNode>(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildTask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBTCompositeChild.__PropertyOffset_ChildTask, value);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x00020007 File Offset: 0x0001E207
		public TArray<UBTDecorator> Decorators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTDecorator> result;
				if ((result = this._Decorators) == null)
				{
					result = (this._Decorators = new TArray<UBTDecorator>(base.NativePtr + (IntPtr)FBTCompositeChild.__PropertyOffset_Decorators, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Decorators.CopyAssign(value);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00020018 File Offset: 0x0001E218
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x0002005B File Offset: 0x0001E25B
		public TArray<FBTDecoratorLogic> DecoratorOps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBTDecoratorLogic> result;
				if ((result = this._DecoratorOps) == null)
				{
					result = (this._DecoratorOps = new TArray<FBTDecoratorLogic>(base.NativePtr + (IntPtr)FBTCompositeChild.__PropertyOffset_DecoratorOps, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DecoratorOps.CopyAssign(value);
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00020069 File Offset: 0x0001E269
		public FBTCompositeChild()
		{
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00020071 File Offset: 0x0001E271
		public FBTCompositeChild(UBTCompositeNode ChildComposite, UBTTaskNode ChildTask, TArray<UBTDecorator> Decorators, TArray<FBTDecoratorLogic> DecoratorOps)
		{
			this.ChildComposite = ChildComposite;
			this.ChildTask = ChildTask;
			this.Decorators = Decorators;
			this.DecoratorOps = DecoratorOps;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00020096 File Offset: 0x0001E296
		protected override IntPtr GetUStructPtr()
		{
			return FBTCompositeChild.StaticStruct();
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000200A2 File Offset: 0x0001E2A2
		[NullableContext(2)]
		public FBTCompositeChild(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000200AC File Offset: 0x0001E2AC
		public FBTCompositeChild(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000200B7 File Offset: 0x0001E2B7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBTCompositeChild(Pointer, false, true);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000200C1 File Offset: 0x0001E2C1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBTCompositeChild(Pointer, MemoryOwner);
		}

		// Token: 0x040004B6 RID: 1206
		public const string __ObjectPath = "/Script/AIModule.BTCompositeChild";

		// Token: 0x040004B7 RID: 1207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040004B8 RID: 1208
		internal static int __PropertyOffset_ChildComposite;

		// Token: 0x040004B9 RID: 1209
		internal static int __PropertyOffset_ChildTask;

		// Token: 0x040004BA RID: 1210
		internal static int __PropertyOffset_Decorators;

		// Token: 0x040004BB RID: 1211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTDecorator> _Decorators;

		// Token: 0x040004BC RID: 1212
		internal static int __PropertyOffset_DecoratorOps;

		// Token: 0x040004BD RID: 1213
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBTDecoratorLogic> _DecoratorOps;
	}
}
