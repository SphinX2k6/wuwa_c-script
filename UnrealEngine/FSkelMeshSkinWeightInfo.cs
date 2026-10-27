using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200110F RID: 4367
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkelMeshSkinWeightInfo")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FSkelMeshSkinWeightInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FD63 RID: 64867 RVA: 0x00176350 File Offset: 0x00174550
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkelMeshSkinWeightInfo._ScriptStructPtr != 0) ? FSkelMeshSkinWeightInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkelMeshSkinWeightInfo", ref FSkelMeshSkinWeightInfo._ScriptStructPtr);
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600FD64 RID: 64868 RVA: 0x00176374 File Offset: 0x00174574
		// (set) Token: 0x0600FD65 RID: 64869 RVA: 0x001763B9 File Offset: 0x001745B9
		public TFixedArray<int> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TFixedArray<int>(base.NativePtr + (IntPtr)FSkelMeshSkinWeightInfo.__PropertyOffset_Bones, 12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600FD66 RID: 64870 RVA: 0x001763C8 File Offset: 0x001745C8
		// (set) Token: 0x0600FD67 RID: 64871 RVA: 0x0017640D File Offset: 0x0017460D
		public TFixedArray<byte> Weights
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<byte> result;
				if ((result = this._Weights) == null)
				{
					result = (this._Weights = new TFixedArray<byte>(base.NativePtr + (IntPtr)FSkelMeshSkinWeightInfo.__PropertyOffset_Weights, 12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Weights.CopyAssign(value);
			}
		}

		// Token: 0x0600FD68 RID: 64872 RVA: 0x0017641B File Offset: 0x0017461B
		public FSkelMeshSkinWeightInfo()
		{
		}

		// Token: 0x0600FD69 RID: 64873 RVA: 0x00176423 File Offset: 0x00174623
		public FSkelMeshSkinWeightInfo(TFixedArray<int> Bones, TFixedArray<byte> Weights)
		{
			this.Bones = Bones;
			this.Weights = Weights;
		}

		// Token: 0x0600FD6A RID: 64874 RVA: 0x00176439 File Offset: 0x00174639
		protected override IntPtr GetUStructPtr()
		{
			return FSkelMeshSkinWeightInfo.StaticStruct();
		}

		// Token: 0x0600FD6B RID: 64875 RVA: 0x00176445 File Offset: 0x00174645
		[NullableContext(2)]
		public FSkelMeshSkinWeightInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FD6C RID: 64876 RVA: 0x0017644F File Offset: 0x0017464F
		public FSkelMeshSkinWeightInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FD6D RID: 64877 RVA: 0x0017645A File Offset: 0x0017465A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkelMeshSkinWeightInfo(Pointer, false, true);
		}

		// Token: 0x0600FD6E RID: 64878 RVA: 0x00176464 File Offset: 0x00174664
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkelMeshSkinWeightInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040088A0 RID: 34976
		public const string __ObjectPath = "/Script/Engine.SkelMeshSkinWeightInfo";

		// Token: 0x040088A1 RID: 34977
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040088A2 RID: 34978
		internal static int __PropertyOffset_Bones;

		// Token: 0x040088A3 RID: 34979
		[Nullable(2)]
		private TFixedArray<int> _Bones;

		// Token: 0x040088A4 RID: 34980
		internal static int __PropertyOffset_Weights;

		// Token: 0x040088A5 RID: 34981
		[Nullable(2)]
		private TFixedArray<byte> _Weights;
	}
}
