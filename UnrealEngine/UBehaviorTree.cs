using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011B RID: 283
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BehaviorTree")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UBehaviorTree : UObject, IUnrealUObject, IUnrealObject, IBlackboardAssetProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x0001E896 File Offset: 0x0001CA96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBehaviorTree._ClassPtr;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0001E8A2 File Offset: 0x0001CAA2
		int IBlackboardAssetProvider.InterfaceOffset()
		{
			return UBehaviorTree.__InterfaceOffset_IBlackboardAssetProvider;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0001E8AC File Offset: 0x0001CAAC
		public UBehaviorTree() : this(BuiltinUtils.AllocNativeUObject(UBehaviorTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
		public UBehaviorTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBehaviorTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0001E907 File Offset: 0x0001CB07
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0001E91B File Offset: 0x0001CB1B
		[Nullable(2)]
		public unsafe UBTCompositeNode RootNode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBTCompositeNode>(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTree.__PropertyOffset_RootNode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTree.__PropertyOffset_RootNode, value);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0001E930 File Offset: 0x0001CB30
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0001E944 File Offset: 0x0001CB44
		[Nullable(2)]
		public unsafe UBlackboardData BlackboardAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardData>(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTree.__PropertyOffset_BlackboardAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBehaviorTree.__PropertyOffset_BlackboardAsset, value);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0001E95C File Offset: 0x0001CB5C
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0001E995 File Offset: 0x0001CB95
		public TArray<UBTDecorator> RootDecorators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTDecorator> result;
				if ((result = this._RootDecorators) == null)
				{
					result = (this._RootDecorators = new TArray<UBTDecorator>(base.NativePtr + (IntPtr)UBehaviorTree.__PropertyOffset_RootDecorators, this));
				}
				return result;
			}
			set
			{
				this.RootDecorators.CopyAssign(value);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0001E9A4 File Offset: 0x0001CBA4
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0001E9DD File Offset: 0x0001CBDD
		public TArray<FBTDecoratorLogic> RootDecoratorOps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBTDecoratorLogic> result;
				if ((result = this._RootDecoratorOps) == null)
				{
					result = (this._RootDecoratorOps = new TArray<FBTDecoratorLogic>(base.NativePtr + (IntPtr)UBehaviorTree.__PropertyOffset_RootDecoratorOps, this));
				}
				return result;
			}
			set
			{
				this.RootDecoratorOps.CopyAssign(value);
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0001E9EB File Offset: 0x0001CBEB
		static UBehaviorTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BehaviorTree");
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0001E9F9 File Offset: 0x0001CBF9
		protected UBehaviorTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400043F RID: 1087
		internal static int __InterfaceOffset_IBlackboardAssetProvider;

		// Token: 0x04000440 RID: 1088
		public new const string __ObjectPath = "/Script/AIModule.BehaviorTree";

		// Token: 0x04000441 RID: 1089
		private static IntPtr _ClassPtr;

		// Token: 0x04000442 RID: 1090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000443 RID: 1091
		internal static int __PropertyOffset_RootNode;

		// Token: 0x04000444 RID: 1092
		internal static int __PropertyOffset_BlackboardAsset;

		// Token: 0x04000445 RID: 1093
		internal static int __PropertyOffset_RootDecorators;

		// Token: 0x04000446 RID: 1094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTDecorator> _RootDecorators;

		// Token: 0x04000447 RID: 1095
		internal static int __PropertyOffset_RootDecoratorOps;

		// Token: 0x04000448 RID: 1096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBTDecoratorLogic> _RootDecoratorOps;
	}
}
