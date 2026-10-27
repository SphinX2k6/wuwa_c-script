using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002087 RID: 8327
	[UnrealObjectPath("/Script/LGUI.LGUIMapTilesSyncer")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class ULGUIMapTilesSyncer : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F6C3 RID: 128707 RVA: 0x002EAC28 File Offset: 0x002E8E28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIMapTilesSyncer._ClassPtr;
		}

		// Token: 0x0601F6C4 RID: 128708 RVA: 0x002EAC34 File Offset: 0x002E8E34
		public ULGUIMapTilesSyncer() : this(BuiltinUtils.AllocNativeUObject(ULGUIMapTilesSyncer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F6C5 RID: 128709 RVA: 0x002EAC5C File Offset: 0x002E8E5C
		[NullableContext(1)]
		public ULGUIMapTilesSyncer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIMapTilesSyncer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C0A RID: 31754
		// (get) Token: 0x0601F6C6 RID: 128710 RVA: 0x002EAC8F File Offset: 0x002E8E8F
		// (set) Token: 0x0601F6C7 RID: 128711 RVA: 0x002EACA3 File Offset: 0x002E8EA3
		[Nullable(2)]
		public unsafe AActor TilesRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIMapTilesSyncer.__PropertyOffset_TilesRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIMapTilesSyncer.__PropertyOffset_TilesRoot, value);
			}
		}

		// Token: 0x0601F6C8 RID: 128712 RVA: 0x002EACB8 File Offset: 0x002E8EB8
		static ULGUIMapTilesSyncer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIMapTilesSyncer");
		}

		// Token: 0x0601F6C9 RID: 128713 RVA: 0x002EACC6 File Offset: 0x002E8EC6
		protected ULGUIMapTilesSyncer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F8D RID: 69517
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIMapTilesSyncer";

		// Token: 0x04010F8E RID: 69518
		private static IntPtr _ClassPtr;

		// Token: 0x04010F8F RID: 69519
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F90 RID: 69520
		internal static int __PropertyOffset_TilesRoot;
	}
}
