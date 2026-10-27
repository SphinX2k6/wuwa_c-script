using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002490 RID: 9360
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationGraphNodeComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UNavigationGraphNodeComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023018 RID: 143384 RVA: 0x0033C24D File Offset: 0x0033A44D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationGraphNodeComponent._ClassPtr;
		}

		// Token: 0x06023019 RID: 143385 RVA: 0x0033C25C File Offset: 0x0033A45C
		public UNavigationGraphNodeComponent() : this(BuiltinUtils.AllocNativeUObject(UNavigationGraphNodeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602301A RID: 143386 RVA: 0x0033C284 File Offset: 0x0033A484
		[NullableContext(1)]
		public UNavigationGraphNodeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationGraphNodeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700867D RID: 34429
		// (get) Token: 0x0602301B RID: 143387 RVA: 0x0033C2B8 File Offset: 0x0033A4B8
		// (set) Token: 0x0602301C RID: 143388 RVA: 0x0033C2F1 File Offset: 0x0033A4F1
		[Nullable(1)]
		public FNavGraphNode Node
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavGraphNode result;
				if ((result = this._Node) == null)
				{
					result = (this._Node = new FNavGraphNode(base.NativePtr + (IntPtr)UNavigationGraphNodeComponent.__PropertyOffset_Node, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavGraphNode.StaticStruct(), base.NativePtr + (IntPtr)UNavigationGraphNodeComponent.__PropertyOffset_Node, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700867E RID: 34430
		// (get) Token: 0x0602301D RID: 143389 RVA: 0x0033C312 File Offset: 0x0033A512
		// (set) Token: 0x0602301E RID: 143390 RVA: 0x0033C326 File Offset: 0x0033A526
		public unsafe UNavigationGraphNodeComponent NextNodeComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationGraphNodeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationGraphNodeComponent.__PropertyOffset_NextNodeComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationGraphNodeComponent.__PropertyOffset_NextNodeComponent, value);
			}
		}

		// Token: 0x1700867F RID: 34431
		// (get) Token: 0x0602301F RID: 143391 RVA: 0x0033C33B File Offset: 0x0033A53B
		// (set) Token: 0x06023020 RID: 143392 RVA: 0x0033C34F File Offset: 0x0033A54F
		public unsafe UNavigationGraphNodeComponent PrevNodeComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationGraphNodeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationGraphNodeComponent.__PropertyOffset_PrevNodeComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavigationGraphNodeComponent.__PropertyOffset_PrevNodeComponent, value);
			}
		}

		// Token: 0x06023021 RID: 143393 RVA: 0x0033C364 File Offset: 0x0033A564
		static UNavigationGraphNodeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationGraphNodeComponent");
		}

		// Token: 0x06023022 RID: 143394 RVA: 0x0033C372 File Offset: 0x0033A572
		protected UNavigationGraphNodeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B0D RID: 76557
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationGraphNodeComponent";

		// Token: 0x04012B0E RID: 76558
		private static IntPtr _ClassPtr;

		// Token: 0x04012B0F RID: 76559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B10 RID: 76560
		internal static int __PropertyOffset_Node;

		// Token: 0x04012B11 RID: 76561
		private FNavGraphNode _Node;

		// Token: 0x04012B12 RID: 76562
		internal static int __PropertyOffset_NextNodeComponent;

		// Token: 0x04012B13 RID: 76563
		internal static int __PropertyOffset_PrevNodeComponent;
	}
}
