using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200164E RID: 5710
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.HitBones")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FHitBones : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148E2 RID: 84194 RVA: 0x001E3C44 File Offset: 0x001E1E44
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHitBones._ScriptStructPtr != 0) ? FHitBones._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.HitBones", ref FHitBones._ScriptStructPtr);
		}

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x060148E3 RID: 84195 RVA: 0x001E3C68 File Offset: 0x001E1E68
		// (set) Token: 0x060148E4 RID: 84196 RVA: 0x001E3CAB File Offset: 0x001E1EAB
		public TArray<FName> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<FName>(base.NativePtr + (IntPtr)FHitBones.__PropertyOffset_Bones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x060148E5 RID: 84197 RVA: 0x001E3CB9 File Offset: 0x001E1EB9
		public FHitBones()
		{
		}

		// Token: 0x060148E6 RID: 84198 RVA: 0x001E3CC1 File Offset: 0x001E1EC1
		public FHitBones(TArray<FName> Bones)
		{
			this.Bones = Bones;
		}

		// Token: 0x060148E7 RID: 84199 RVA: 0x001E3CD0 File Offset: 0x001E1ED0
		protected override IntPtr GetUStructPtr()
		{
			return FHitBones.StaticStruct();
		}

		// Token: 0x060148E8 RID: 84200 RVA: 0x001E3CDC File Offset: 0x001E1EDC
		[NullableContext(2)]
		public FHitBones(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148E9 RID: 84201 RVA: 0x001E3CE6 File Offset: 0x001E1EE6
		public FHitBones(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148EA RID: 84202 RVA: 0x001E3CF1 File Offset: 0x001E1EF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHitBones(Pointer, false, true);
		}

		// Token: 0x060148EB RID: 84203 RVA: 0x001E3CFB File Offset: 0x001E1EFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHitBones(Pointer, MemoryOwner);
		}

		// Token: 0x0400B395 RID: 45973
		public const string __ObjectPath = "/Script/KuroAnim.HitBones";

		// Token: 0x0400B396 RID: 45974
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B397 RID: 45975
		internal static int __PropertyOffset_Bones;

		// Token: 0x0400B398 RID: 45976
		[Nullable(2)]
		private TArray<FName> _Bones;
	}
}
