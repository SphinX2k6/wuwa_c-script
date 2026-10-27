using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B6D RID: 7021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedTextureGroup")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroMaterialNamedTextureGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A926 RID: 108838 RVA: 0x00272CCE File Offset: 0x00270ECE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedTextureGroup._ScriptStructPtr != 0) ? FKuroMaterialNamedTextureGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedTextureGroup", ref FKuroMaterialNamedTextureGroup._ScriptStructPtr);
		}

		// Token: 0x17006AC3 RID: 27331
		// (get) Token: 0x0601A927 RID: 108839 RVA: 0x00272CF2 File Offset: 0x00270EF2
		// (set) Token: 0x0601A928 RID: 108840 RVA: 0x00272D06 File Offset: 0x00270F06
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedTextureGroup.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedTextureGroup.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006AC4 RID: 27332
		// (get) Token: 0x0601A929 RID: 108841 RVA: 0x00272D1C File Offset: 0x00270F1C
		// (set) Token: 0x0601A92A RID: 108842 RVA: 0x00272D5F File Offset: 0x00270F5F
		public FKuroMaterialTextureGroup Group
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialTextureGroup result;
				if ((result = this._Group) == null)
				{
					result = (this._Group = new FKuroMaterialTextureGroup(base.NativePtr + (IntPtr)FKuroMaterialNamedTextureGroup.__PropertyOffset_Group, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialTextureGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialNamedTextureGroup.__PropertyOffset_Group, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A92B RID: 108843 RVA: 0x00272D80 File Offset: 0x00270F80
		public FKuroMaterialNamedTextureGroup()
		{
		}

		// Token: 0x0601A92C RID: 108844 RVA: 0x00272D88 File Offset: 0x00270F88
		public FKuroMaterialNamedTextureGroup(FName Name, FKuroMaterialTextureGroup Group)
		{
			this.Name = Name;
			this.Group = Group;
		}

		// Token: 0x0601A92D RID: 108845 RVA: 0x00272D9E File Offset: 0x00270F9E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedTextureGroup.StaticStruct();
		}

		// Token: 0x0601A92E RID: 108846 RVA: 0x00272DAA File Offset: 0x00270FAA
		[NullableContext(2)]
		public FKuroMaterialNamedTextureGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A92F RID: 108847 RVA: 0x00272DB4 File Offset: 0x00270FB4
		public FKuroMaterialNamedTextureGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A930 RID: 108848 RVA: 0x00272DBF File Offset: 0x00270FBF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedTextureGroup(Pointer, false, true);
		}

		// Token: 0x0601A931 RID: 108849 RVA: 0x00272DC9 File Offset: 0x00270FC9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedTextureGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400E62E RID: 58926
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedTextureGroup";

		// Token: 0x0400E62F RID: 58927
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E630 RID: 58928
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E631 RID: 58929
		internal static int __PropertyOffset_Group;

		// Token: 0x0400E632 RID: 58930
		[Nullable(2)]
		private FKuroMaterialTextureGroup _Group;
	}
}
