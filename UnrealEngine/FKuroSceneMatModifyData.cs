using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C7E RID: 7294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneMatModifyData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroSceneMatModifyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C524 RID: 116004 RVA: 0x0029BDB5 File Offset: 0x00299FB5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneMatModifyData._ScriptStructPtr != 0) ? FKuroSceneMatModifyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSceneModifier.KuroSceneMatModifyData", ref FKuroSceneMatModifyData._ScriptStructPtr);
		}

		// Token: 0x17007286 RID: 29318
		// (get) Token: 0x0601C525 RID: 116005 RVA: 0x0029BDD9 File Offset: 0x00299FD9
		// (set) Token: 0x0601C526 RID: 116006 RVA: 0x0029BDED File Offset: 0x00299FED
		[Nullable(2)]
		public unsafe UStaticMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSceneMatModifyData.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSceneMatModifyData.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17007287 RID: 29319
		// (get) Token: 0x0601C527 RID: 116007 RVA: 0x0029BE04 File Offset: 0x0029A004
		// (set) Token: 0x0601C528 RID: 116008 RVA: 0x0029BE47 File Offset: 0x0029A047
		public TArray<UMaterialInstanceConstant> MatModifyArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._MatModifyArray) == null)
				{
					result = (this._MatModifyArray = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)FKuroSceneMatModifyData.__PropertyOffset_MatModifyArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MatModifyArray.CopyAssign(value);
			}
		}

		// Token: 0x0601C529 RID: 116009 RVA: 0x0029BE55 File Offset: 0x0029A055
		public FKuroSceneMatModifyData()
		{
		}

		// Token: 0x0601C52A RID: 116010 RVA: 0x0029BE5D File Offset: 0x0029A05D
		public FKuroSceneMatModifyData(UStaticMesh Mesh, TArray<UMaterialInstanceConstant> MatModifyArray)
		{
			this.Mesh = Mesh;
			this.MatModifyArray = MatModifyArray;
		}

		// Token: 0x0601C52B RID: 116011 RVA: 0x0029BE73 File Offset: 0x0029A073
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSceneMatModifyData.StaticStruct();
		}

		// Token: 0x0601C52C RID: 116012 RVA: 0x0029BE7F File Offset: 0x0029A07F
		[NullableContext(2)]
		public FKuroSceneMatModifyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C52D RID: 116013 RVA: 0x0029BE89 File Offset: 0x0029A089
		public FKuroSceneMatModifyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C52E RID: 116014 RVA: 0x0029BE94 File Offset: 0x0029A094
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSceneMatModifyData(Pointer, false, true);
		}

		// Token: 0x0601C52F RID: 116015 RVA: 0x0029BE9E File Offset: 0x0029A09E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSceneMatModifyData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F39B RID: 62363
		public const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneMatModifyData";

		// Token: 0x0400F39C RID: 62364
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F39D RID: 62365
		internal static int __PropertyOffset_Mesh;

		// Token: 0x0400F39E RID: 62366
		internal static int __PropertyOffset_MatModifyArray;

		// Token: 0x0400F39F RID: 62367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _MatModifyArray;
	}
}
