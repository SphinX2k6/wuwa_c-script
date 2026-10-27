using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FC8 RID: 8136
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ActorGuidAndPrefabContainer")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FActorGuidAndPrefabContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDDA RID: 126426 RVA: 0x002DDF21 File Offset: 0x002DC121
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorGuidAndPrefabContainer._ScriptStructPtr != 0) ? FActorGuidAndPrefabContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ActorGuidAndPrefabContainer", ref FActorGuidAndPrefabContainer._ScriptStructPtr);
		}

		// Token: 0x17007AD5 RID: 31445
		// (get) Token: 0x0601EDDB RID: 126427 RVA: 0x002DDF45 File Offset: 0x002DC145
		// (set) Token: 0x0601EDDC RID: 126428 RVA: 0x002DDF59 File Offset: 0x002DC159
		[Nullable(2)]
		public unsafe ULGUIPrefab Prefab
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIPrefab>(base.NativePtr / (IntPtr)sizeof(void*) + FActorGuidAndPrefabContainer.__PropertyOffset_Prefab);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActorGuidAndPrefabContainer.__PropertyOffset_Prefab, value);
			}
		}

		// Token: 0x17007AD6 RID: 31446
		// (get) Token: 0x0601EDDD RID: 126429 RVA: 0x002DDF70 File Offset: 0x002DC170
		// (set) Token: 0x0601EDDE RID: 126430 RVA: 0x002DDFB3 File Offset: 0x002DC1B3
		public TMap<FGuid, FGuid> GuidFromPrefabToInstance
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FGuid> result;
				if ((result = this._GuidFromPrefabToInstance) == null)
				{
					result = (this._GuidFromPrefabToInstance = new TMap<FGuid, FGuid>(base.NativePtr + (IntPtr)FActorGuidAndPrefabContainer.__PropertyOffset_GuidFromPrefabToInstance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GuidFromPrefabToInstance.CopyAssign(value);
			}
		}

		// Token: 0x0601EDDF RID: 126431 RVA: 0x002DDFC1 File Offset: 0x002DC1C1
		public FActorGuidAndPrefabContainer()
		{
		}

		// Token: 0x0601EDE0 RID: 126432 RVA: 0x002DDFC9 File Offset: 0x002DC1C9
		public FActorGuidAndPrefabContainer(ULGUIPrefab Prefab, TMap<FGuid, FGuid> GuidFromPrefabToInstance)
		{
			this.Prefab = Prefab;
			this.GuidFromPrefabToInstance = GuidFromPrefabToInstance;
		}

		// Token: 0x0601EDE1 RID: 126433 RVA: 0x002DDFDF File Offset: 0x002DC1DF
		protected override IntPtr GetUStructPtr()
		{
			return FActorGuidAndPrefabContainer.StaticStruct();
		}

		// Token: 0x0601EDE2 RID: 126434 RVA: 0x002DDFEB File Offset: 0x002DC1EB
		[NullableContext(2)]
		public FActorGuidAndPrefabContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDE3 RID: 126435 RVA: 0x002DDFF5 File Offset: 0x002DC1F5
		public FActorGuidAndPrefabContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDE4 RID: 126436 RVA: 0x002DE000 File Offset: 0x002DC200
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorGuidAndPrefabContainer(Pointer, false, true);
		}

		// Token: 0x0601EDE5 RID: 126437 RVA: 0x002DE00A File Offset: 0x002DC20A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorGuidAndPrefabContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04010ACF RID: 68303
		public const string __ObjectPath = "/Script/LGUI.ActorGuidAndPrefabContainer";

		// Token: 0x04010AD0 RID: 68304
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AD1 RID: 68305
		internal static int __PropertyOffset_Prefab;

		// Token: 0x04010AD2 RID: 68306
		internal static int __PropertyOffset_GuidFromPrefabToInstance;

		// Token: 0x04010AD3 RID: 68307
		[Nullable(2)]
		private TMap<FGuid, FGuid> _GuidFromPrefabToInstance;
	}
}
