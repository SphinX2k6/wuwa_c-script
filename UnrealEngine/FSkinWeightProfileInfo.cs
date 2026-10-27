using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001111 RID: 4369
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkinWeightProfileInfo")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FSkinWeightProfileInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FE44 RID: 65092 RVA: 0x00177465 File Offset: 0x00175665
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkinWeightProfileInfo._ScriptStructPtr != 0) ? FSkinWeightProfileInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkinWeightProfileInfo", ref FSkinWeightProfileInfo._ScriptStructPtr);
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600FE45 RID: 65093 RVA: 0x00177489 File Offset: 0x00175689
		// (set) Token: 0x0600FE46 RID: 65094 RVA: 0x0017749D File Offset: 0x0017569D
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkinWeightProfileInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkinWeightProfileInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600FE47 RID: 65095 RVA: 0x001774B4 File Offset: 0x001756B4
		// (set) Token: 0x0600FE48 RID: 65096 RVA: 0x001774F7 File Offset: 0x001756F7
		public FPerPlatformBool DefaultProfile
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformBool result;
				if ((result = this._DefaultProfile) == null)
				{
					result = (this._DefaultProfile = new FPerPlatformBool(base.NativePtr + (IntPtr)FSkinWeightProfileInfo.__PropertyOffset_DefaultProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformBool.StaticStruct(), base.NativePtr + (IntPtr)FSkinWeightProfileInfo.__PropertyOffset_DefaultProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600FE49 RID: 65097 RVA: 0x00177518 File Offset: 0x00175718
		// (set) Token: 0x0600FE4A RID: 65098 RVA: 0x0017755B File Offset: 0x0017575B
		public FPerPlatformInt DefaultProfileFromLODIndex
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._DefaultProfileFromLODIndex) == null)
				{
					result = (this._DefaultProfileFromLODIndex = new FPerPlatformInt(base.NativePtr + (IntPtr)FSkinWeightProfileInfo.__PropertyOffset_DefaultProfileFromLODIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FSkinWeightProfileInfo.__PropertyOffset_DefaultProfileFromLODIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600FE4B RID: 65099 RVA: 0x0017757C File Offset: 0x0017577C
		public FSkinWeightProfileInfo()
		{
		}

		// Token: 0x0600FE4C RID: 65100 RVA: 0x00177584 File Offset: 0x00175784
		public FSkinWeightProfileInfo(FName Name, FPerPlatformBool DefaultProfile, FPerPlatformInt DefaultProfileFromLODIndex, TMap<int, string> PerLODSourceFiles)
		{
			this.Name = Name;
			this.DefaultProfile = DefaultProfile;
			this.DefaultProfileFromLODIndex = DefaultProfileFromLODIndex;
		}

		// Token: 0x0600FE4D RID: 65101 RVA: 0x001775A1 File Offset: 0x001757A1
		protected override IntPtr GetUStructPtr()
		{
			return FSkinWeightProfileInfo.StaticStruct();
		}

		// Token: 0x0600FE4E RID: 65102 RVA: 0x001775AD File Offset: 0x001757AD
		[NullableContext(2)]
		public FSkinWeightProfileInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FE4F RID: 65103 RVA: 0x001775B7 File Offset: 0x001757B7
		public FSkinWeightProfileInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FE50 RID: 65104 RVA: 0x001775C2 File Offset: 0x001757C2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkinWeightProfileInfo(Pointer, false, true);
		}

		// Token: 0x0600FE51 RID: 65105 RVA: 0x001775CC File Offset: 0x001757CC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkinWeightProfileInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040088F9 RID: 35065
		public const string __ObjectPath = "/Script/Engine.SkinWeightProfileInfo";

		// Token: 0x040088FA RID: 35066
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040088FB RID: 35067
		internal static int __PropertyOffset_Name;

		// Token: 0x040088FC RID: 35068
		internal static int __PropertyOffset_DefaultProfile;

		// Token: 0x040088FD RID: 35069
		[Nullable(2)]
		private FPerPlatformBool _DefaultProfile;

		// Token: 0x040088FE RID: 35070
		internal static int __PropertyOffset_DefaultProfileFromLODIndex;

		// Token: 0x040088FF RID: 35071
		[Nullable(2)]
		private FPerPlatformInt _DefaultProfileFromLODIndex;
	}
}
