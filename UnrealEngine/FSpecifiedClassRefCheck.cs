using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200116E RID: 4462
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpecifiedClassRefCheck")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSpecifiedClassRefCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060104E5 RID: 66789 RVA: 0x0018051E File Offset: 0x0017E71E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpecifiedClassRefCheck._ScriptStructPtr != 0) ? FSpecifiedClassRefCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpecifiedClassRefCheck", ref FSpecifiedClassRefCheck._ScriptStructPtr);
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x060104E6 RID: 66790 RVA: 0x00180544 File Offset: 0x0017E744
		// (set) Token: 0x060104E7 RID: 66791 RVA: 0x00180587 File Offset: 0x0017E787
		public TArray<string> StaticMeshActorRefMesh
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StaticMeshActorRefMesh) == null)
				{
					result = (this._StaticMeshActorRefMesh = new TArray<string>(base.NativePtr + (IntPtr)FSpecifiedClassRefCheck.__PropertyOffset_StaticMeshActorRefMesh, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshActorRefMesh.CopyAssign(value);
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x060104E8 RID: 66792 RVA: 0x00180598 File Offset: 0x0017E798
		// (set) Token: 0x060104E9 RID: 66793 RVA: 0x001805DB File Offset: 0x0017E7DB
		public TArray<string> DecalActorMeshRefMat
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DecalActorMeshRefMat) == null)
				{
					result = (this._DecalActorMeshRefMat = new TArray<string>(base.NativePtr + (IntPtr)FSpecifiedClassRefCheck.__PropertyOffset_DecalActorMeshRefMat, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DecalActorMeshRefMat.CopyAssign(value);
			}
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x060104EA RID: 66794 RVA: 0x001805EC File Offset: 0x0017E7EC
		// (set) Token: 0x060104EB RID: 66795 RVA: 0x0018062F File Offset: 0x0017E82F
		public TArray<string> LevelInstanceBehavior
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LevelInstanceBehavior) == null)
				{
					result = (this._LevelInstanceBehavior = new TArray<string>(base.NativePtr + (IntPtr)FSpecifiedClassRefCheck.__PropertyOffset_LevelInstanceBehavior, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LevelInstanceBehavior.CopyAssign(value);
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x060104EC RID: 66796 RVA: 0x00180640 File Offset: 0x0017E840
		// (set) Token: 0x060104ED RID: 66797 RVA: 0x00180683 File Offset: 0x0017E883
		public TArray<string> StaticMeshComponentCheckBP
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StaticMeshComponentCheckBP) == null)
				{
					result = (this._StaticMeshComponentCheckBP = new TArray<string>(base.NativePtr + (IntPtr)FSpecifiedClassRefCheck.__PropertyOffset_StaticMeshComponentCheckBP, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshComponentCheckBP.CopyAssign(value);
			}
		}

		// Token: 0x060104EE RID: 66798 RVA: 0x00180691 File Offset: 0x0017E891
		public FSpecifiedClassRefCheck()
		{
		}

		// Token: 0x060104EF RID: 66799 RVA: 0x00180699 File Offset: 0x0017E899
		public FSpecifiedClassRefCheck(TArray<string> StaticMeshActorRefMesh, TArray<string> DecalActorMeshRefMat, TArray<string> LevelInstanceBehavior, TArray<string> StaticMeshComponentCheckBP)
		{
			this.StaticMeshActorRefMesh = StaticMeshActorRefMesh;
			this.DecalActorMeshRefMat = DecalActorMeshRefMat;
			this.LevelInstanceBehavior = LevelInstanceBehavior;
			this.StaticMeshComponentCheckBP = StaticMeshComponentCheckBP;
		}

		// Token: 0x060104F0 RID: 66800 RVA: 0x001806BE File Offset: 0x0017E8BE
		protected override IntPtr GetUStructPtr()
		{
			return FSpecifiedClassRefCheck.StaticStruct();
		}

		// Token: 0x060104F1 RID: 66801 RVA: 0x001806CA File Offset: 0x0017E8CA
		[NullableContext(2)]
		public FSpecifiedClassRefCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060104F2 RID: 66802 RVA: 0x001806D4 File Offset: 0x0017E8D4
		public FSpecifiedClassRefCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060104F3 RID: 66803 RVA: 0x001806DF File Offset: 0x0017E8DF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpecifiedClassRefCheck(Pointer, false, true);
		}

		// Token: 0x060104F4 RID: 66804 RVA: 0x001806E9 File Offset: 0x0017E8E9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpecifiedClassRefCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04008C52 RID: 35922
		public const string __ObjectPath = "/Script/Engine.SpecifiedClassRefCheck";

		// Token: 0x04008C53 RID: 35923
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C54 RID: 35924
		internal static int __PropertyOffset_StaticMeshActorRefMesh;

		// Token: 0x04008C55 RID: 35925
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StaticMeshActorRefMesh;

		// Token: 0x04008C56 RID: 35926
		internal static int __PropertyOffset_DecalActorMeshRefMat;

		// Token: 0x04008C57 RID: 35927
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DecalActorMeshRefMat;

		// Token: 0x04008C58 RID: 35928
		internal static int __PropertyOffset_LevelInstanceBehavior;

		// Token: 0x04008C59 RID: 35929
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LevelInstanceBehavior;

		// Token: 0x04008C5A RID: 35930
		internal static int __PropertyOffset_StaticMeshComponentCheckBP;

		// Token: 0x04008C5B RID: 35931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StaticMeshComponentCheckBP;
	}
}
