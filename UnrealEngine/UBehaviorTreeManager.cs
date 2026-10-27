using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011D RID: 285
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BehaviorTreeManager")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UBehaviorTreeManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060014D9 RID: 5337 RVA: 0x0001EB2F File Offset: 0x0001CD2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBehaviorTreeManager._ClassPtr;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0001EB3C File Offset: 0x0001CD3C
		public UBehaviorTreeManager() : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0001EB64 File Offset: 0x0001CD64
		public UBehaviorTreeManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0001EB97 File Offset: 0x0001CD97
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x0001EBA7 File Offset: 0x0001CDA7
		public unsafe int MaxDebuggerSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBehaviorTreeManager.__PropertyOffset_MaxDebuggerSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBehaviorTreeManager.__PropertyOffset_MaxDebuggerSteps) = value;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0001EBB8 File Offset: 0x0001CDB8
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x0001EBF1 File Offset: 0x0001CDF1
		public TArray<FBehaviorTreeTemplateInfo> LoadedTemplates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBehaviorTreeTemplateInfo> result;
				if ((result = this._LoadedTemplates) == null)
				{
					result = (this._LoadedTemplates = new TArray<FBehaviorTreeTemplateInfo>(base.NativePtr + (IntPtr)UBehaviorTreeManager.__PropertyOffset_LoadedTemplates, this));
				}
				return result;
			}
			set
			{
				this.LoadedTemplates.CopyAssign(value);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0001EC00 File Offset: 0x0001CE00
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x0001EC39 File Offset: 0x0001CE39
		public TMap<UBehaviorTree, FBehaviorTreeTemplateInfo> LoadedTemplateMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UBehaviorTree, FBehaviorTreeTemplateInfo> result;
				if ((result = this._LoadedTemplateMap) == null)
				{
					result = (this._LoadedTemplateMap = new TMap<UBehaviorTree, FBehaviorTreeTemplateInfo>(base.NativePtr + (IntPtr)UBehaviorTreeManager.__PropertyOffset_LoadedTemplateMap, this));
				}
				return result;
			}
			set
			{
				this.LoadedTemplateMap.CopyAssign(value);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0001EC48 File Offset: 0x0001CE48
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x0001EC81 File Offset: 0x0001CE81
		public TArray<UBehaviorTreeComponent> ActiveComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBehaviorTreeComponent> result;
				if ((result = this._ActiveComponents) == null)
				{
					result = (this._ActiveComponents = new TArray<UBehaviorTreeComponent>(base.NativePtr + (IntPtr)UBehaviorTreeManager.__PropertyOffset_ActiveComponents, this));
				}
				return result;
			}
			set
			{
				this.ActiveComponents.CopyAssign(value);
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0001EC8F File Offset: 0x0001CE8F
		static UBehaviorTreeManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BehaviorTreeManager");
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0001EC9D File Offset: 0x0001CE9D
		protected UBehaviorTreeManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400044F RID: 1103
		public new const string __ObjectPath = "/Script/AIModule.BehaviorTreeManager";

		// Token: 0x04000450 RID: 1104
		private static IntPtr _ClassPtr;

		// Token: 0x04000451 RID: 1105
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000452 RID: 1106
		internal static int __PropertyOffset_MaxDebuggerSteps;

		// Token: 0x04000453 RID: 1107
		internal static int __PropertyOffset_LoadedTemplates;

		// Token: 0x04000454 RID: 1108
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBehaviorTreeTemplateInfo> _LoadedTemplates;

		// Token: 0x04000455 RID: 1109
		internal static int __PropertyOffset_LoadedTemplateMap;

		// Token: 0x04000456 RID: 1110
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UBehaviorTree, FBehaviorTreeTemplateInfo> _LoadedTemplateMap;

		// Token: 0x04000457 RID: 1111
		internal static int __PropertyOffset_ActiveComponents;

		// Token: 0x04000458 RID: 1112
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBehaviorTreeComponent> _ActiveComponents;
	}
}
