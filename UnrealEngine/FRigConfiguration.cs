using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001093 RID: 4243
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RigConfiguration")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigConfiguration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F278 RID: 62072 RVA: 0x00167C96 File Offset: 0x00165E96
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigConfiguration._ScriptStructPtr != 0) ? FRigConfiguration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RigConfiguration", ref FRigConfiguration._ScriptStructPtr);
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600F279 RID: 62073 RVA: 0x00167CBA File Offset: 0x00165EBA
		// (set) Token: 0x0600F27A RID: 62074 RVA: 0x00167CCE File Offset: 0x00165ECE
		[Nullable(2)]
		public unsafe URig Rig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URig>(base.NativePtr / (IntPtr)sizeof(void*) + FRigConfiguration.__PropertyOffset_Rig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRigConfiguration.__PropertyOffset_Rig, value);
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600F27B RID: 62075 RVA: 0x00167CE4 File Offset: 0x00165EE4
		// (set) Token: 0x0600F27C RID: 62076 RVA: 0x00167D27 File Offset: 0x00165F27
		public TArray<FNameMapping> BoneMappingTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNameMapping> result;
				if ((result = this._BoneMappingTable) == null)
				{
					result = (this._BoneMappingTable = new TArray<FNameMapping>(base.NativePtr + (IntPtr)FRigConfiguration.__PropertyOffset_BoneMappingTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneMappingTable.CopyAssign(value);
			}
		}

		// Token: 0x0600F27D RID: 62077 RVA: 0x00167D35 File Offset: 0x00165F35
		public FRigConfiguration()
		{
		}

		// Token: 0x0600F27E RID: 62078 RVA: 0x00167D3D File Offset: 0x00165F3D
		public FRigConfiguration(URig Rig, TArray<FNameMapping> BoneMappingTable)
		{
			this.Rig = Rig;
			this.BoneMappingTable = BoneMappingTable;
		}

		// Token: 0x0600F27F RID: 62079 RVA: 0x00167D53 File Offset: 0x00165F53
		protected override IntPtr GetUStructPtr()
		{
			return FRigConfiguration.StaticStruct();
		}

		// Token: 0x0600F280 RID: 62080 RVA: 0x00167D5F File Offset: 0x00165F5F
		[NullableContext(2)]
		public FRigConfiguration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F281 RID: 62081 RVA: 0x00167D69 File Offset: 0x00165F69
		public FRigConfiguration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F282 RID: 62082 RVA: 0x00167D74 File Offset: 0x00165F74
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigConfiguration(Pointer, false, true);
		}

		// Token: 0x0600F283 RID: 62083 RVA: 0x00167D7E File Offset: 0x00165F7E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigConfiguration(Pointer, MemoryOwner);
		}

		// Token: 0x04008392 RID: 33682
		public const string __ObjectPath = "/Script/Engine.RigConfiguration";

		// Token: 0x04008393 RID: 33683
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008394 RID: 33684
		internal static int __PropertyOffset_Rig;

		// Token: 0x04008395 RID: 33685
		internal static int __PropertyOffset_BoneMappingTable;

		// Token: 0x04008396 RID: 33686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNameMapping> _BoneMappingTable;
	}
}
