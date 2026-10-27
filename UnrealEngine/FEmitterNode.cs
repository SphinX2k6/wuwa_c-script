using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016EB RID: 5867
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.EmitterNode")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FEmitterNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060152F9 RID: 86777 RVA: 0x001F23D4 File Offset: 0x001F05D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterNode._ScriptStructPtr != 0) ? FEmitterNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.EmitterNode", ref FEmitterNode._ScriptStructPtr);
		}

		// Token: 0x170053C1 RID: 21441
		// (get) Token: 0x060152FA RID: 86778 RVA: 0x001F23F8 File Offset: 0x001F05F8
		// (set) Token: 0x060152FB RID: 86779 RVA: 0x001F240C File Offset: 0x001F060C
		public unsafe FName NodeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterNode.__PropertyOffset_NodeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterNode.__PropertyOffset_NodeName) = value;
			}
		}

		// Token: 0x170053C2 RID: 21442
		// (get) Token: 0x060152FC RID: 86780 RVA: 0x001F2424 File Offset: 0x001F0624
		// (set) Token: 0x060152FD RID: 86781 RVA: 0x001F2467 File Offset: 0x001F0667
		public FEmitterSpawnRule SpawnRule
		{
			get
			{
				base.FastCheckIsValid();
				FEmitterSpawnRule result;
				if ((result = this._SpawnRule) == null)
				{
					result = (this._SpawnRule = new FEmitterSpawnRule(base.NativePtr + (IntPtr)FEmitterNode.__PropertyOffset_SpawnRule, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEmitterSpawnRule.StaticStruct(), base.NativePtr + (IntPtr)FEmitterNode.__PropertyOffset_SpawnRule, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053C3 RID: 21443
		// (get) Token: 0x060152FE RID: 86782 RVA: 0x001F2488 File Offset: 0x001F0688
		// (set) Token: 0x060152FF RID: 86783 RVA: 0x001F249C File Offset: 0x001F069C
		[Nullable(2)]
		public unsafe UKuroBulletEmitterConfig EmitterConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletEmitterConfig>(base.NativePtr / (IntPtr)sizeof(void*) + FEmitterNode.__PropertyOffset_EmitterConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEmitterNode.__PropertyOffset_EmitterConfig, value);
			}
		}

		// Token: 0x06015300 RID: 86784 RVA: 0x001F24B1 File Offset: 0x001F06B1
		public FEmitterNode()
		{
		}

		// Token: 0x06015301 RID: 86785 RVA: 0x001F24B9 File Offset: 0x001F06B9
		public FEmitterNode(FName NodeName, FEmitterSpawnRule SpawnRule, UKuroBulletEmitterConfig EmitterConfig)
		{
			this.NodeName = NodeName;
			this.SpawnRule = SpawnRule;
			this.EmitterConfig = EmitterConfig;
		}

		// Token: 0x06015302 RID: 86786 RVA: 0x001F24D6 File Offset: 0x001F06D6
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterNode.StaticStruct();
		}

		// Token: 0x06015303 RID: 86787 RVA: 0x001F24E2 File Offset: 0x001F06E2
		[NullableContext(2)]
		public FEmitterNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015304 RID: 86788 RVA: 0x001F24EC File Offset: 0x001F06EC
		public FEmitterNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015305 RID: 86789 RVA: 0x001F24F7 File Offset: 0x001F06F7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterNode(Pointer, false, true);
		}

		// Token: 0x06015306 RID: 86790 RVA: 0x001F2501 File Offset: 0x001F0701
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterNode(Pointer, MemoryOwner);
		}

		// Token: 0x0400B8D7 RID: 47319
		public const string __ObjectPath = "/Script/KuroBulletCore.EmitterNode";

		// Token: 0x0400B8D8 RID: 47320
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B8D9 RID: 47321
		internal static int __PropertyOffset_NodeName;

		// Token: 0x0400B8DA RID: 47322
		internal static int __PropertyOffset_SpawnRule;

		// Token: 0x0400B8DB RID: 47323
		[Nullable(2)]
		private FEmitterSpawnRule _SpawnRule;

		// Token: 0x0400B8DC RID: 47324
		internal static int __PropertyOffset_EmitterConfig;
	}
}
