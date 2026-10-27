using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F5 RID: 6389
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelSwitchMaterialData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroLevelSwitchMaterialData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017B2F RID: 97071 RVA: 0x0022BAE2 File Offset: 0x00229CE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelSwitchMaterialData._ScriptStructPtr != 0) ? FKuroLevelSwitchMaterialData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelSwitchMaterialData", ref FKuroLevelSwitchMaterialData._ScriptStructPtr);
		}

		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x06017B30 RID: 97072 RVA: 0x0022BB06 File Offset: 0x00229D06
		// (set) Token: 0x06017B31 RID: 97073 RVA: 0x0022BB1A File Offset: 0x00229D1A
		public unsafe AActor Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_Actor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_Actor, value);
			}
		}

		// Token: 0x17005F7A RID: 24442
		// (get) Token: 0x06017B32 RID: 97074 RVA: 0x0022BB2F File Offset: 0x00229D2F
		// (set) Token: 0x06017B33 RID: 97075 RVA: 0x0022BB3F File Offset: 0x00229D3F
		public unsafe bool bIncludeChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelSwitchMaterialData.__PropertyOffset_bIncludeChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelSwitchMaterialData.__PropertyOffset_bIncludeChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F7B RID: 24443
		// (get) Token: 0x06017B34 RID: 97076 RVA: 0x0022BB50 File Offset: 0x00229D50
		// (set) Token: 0x06017B35 RID: 97077 RVA: 0x0022BB64 File Offset: 0x00229D64
		public unsafe UMaterialInstance EnterMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_EnterMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_EnterMaterial, value);
			}
		}

		// Token: 0x17005F7C RID: 24444
		// (get) Token: 0x06017B36 RID: 97078 RVA: 0x0022BB79 File Offset: 0x00229D79
		// (set) Token: 0x06017B37 RID: 97079 RVA: 0x0022BB8D File Offset: 0x00229D8D
		public unsafe UKuroLevelMaterialDynamicData MaterialAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLevelMaterialDynamicData>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_MaterialAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_MaterialAsset, value);
			}
		}

		// Token: 0x17005F7D RID: 24445
		// (get) Token: 0x06017B38 RID: 97080 RVA: 0x0022BBA2 File Offset: 0x00229DA2
		// (set) Token: 0x06017B39 RID: 97081 RVA: 0x0022BBB2 File Offset: 0x00229DB2
		public unsafe bool bExitReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelSwitchMaterialData.__PropertyOffset_bExitReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelSwitchMaterialData.__PropertyOffset_bExitReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F7E RID: 24446
		// (get) Token: 0x06017B3A RID: 97082 RVA: 0x0022BBC3 File Offset: 0x00229DC3
		// (set) Token: 0x06017B3B RID: 97083 RVA: 0x0022BBD7 File Offset: 0x00229DD7
		public unsafe UMaterialInstance ExitMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_ExitMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroLevelSwitchMaterialData.__PropertyOffset_ExitMaterial, value);
			}
		}

		// Token: 0x06017B3C RID: 97084 RVA: 0x0022BBEC File Offset: 0x00229DEC
		public FKuroLevelSwitchMaterialData()
		{
		}

		// Token: 0x06017B3D RID: 97085 RVA: 0x0022BBF4 File Offset: 0x00229DF4
		[NullableContext(1)]
		public FKuroLevelSwitchMaterialData(AActor Actor, bool bIncludeChildren, UMaterialInstance EnterMaterial, UKuroLevelMaterialDynamicData MaterialAsset, bool bExitReverse, UMaterialInstance ExitMaterial)
		{
			this.Actor = Actor;
			this.bIncludeChildren = bIncludeChildren;
			this.EnterMaterial = EnterMaterial;
			this.MaterialAsset = MaterialAsset;
			this.bExitReverse = bExitReverse;
			this.ExitMaterial = ExitMaterial;
		}

		// Token: 0x06017B3E RID: 97086 RVA: 0x0022BC29 File Offset: 0x00229E29
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelSwitchMaterialData.StaticStruct();
		}

		// Token: 0x06017B3F RID: 97087 RVA: 0x0022BC35 File Offset: 0x00229E35
		public FKuroLevelSwitchMaterialData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017B40 RID: 97088 RVA: 0x0022BC3F File Offset: 0x00229E3F
		public FKuroLevelSwitchMaterialData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017B41 RID: 97089 RVA: 0x0022BC4A File Offset: 0x00229E4A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelSwitchMaterialData(Pointer, false, true);
		}

		// Token: 0x06017B42 RID: 97090 RVA: 0x0022BC54 File Offset: 0x00229E54
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelSwitchMaterialData(Pointer, MemoryOwner);
		}

		// Token: 0x0400CDE2 RID: 52706
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelSwitchMaterialData";

		// Token: 0x0400CDE3 RID: 52707
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CDE4 RID: 52708
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400CDE5 RID: 52709
		internal static int __PropertyOffset_bIncludeChildren;

		// Token: 0x0400CDE6 RID: 52710
		internal static int __PropertyOffset_EnterMaterial;

		// Token: 0x0400CDE7 RID: 52711
		internal static int __PropertyOffset_MaterialAsset;

		// Token: 0x0400CDE8 RID: 52712
		internal static int __PropertyOffset_bExitReverse;

		// Token: 0x0400CDE9 RID: 52713
		internal static int __PropertyOffset_ExitMaterial;
	}
}
