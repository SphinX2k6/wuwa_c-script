using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020B4 RID: 8372
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabOverrideParameterData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FLGUIPrefabOverrideParameterData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F8B4 RID: 129204 RVA: 0x002EE516 File Offset: 0x002EC716
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIPrefabOverrideParameterData._ScriptStructPtr != 0) ? FLGUIPrefabOverrideParameterData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIPrefabOverrideParameterData", ref FLGUIPrefabOverrideParameterData._ScriptStructPtr);
		}

		// Token: 0x17007C6B RID: 31851
		// (get) Token: 0x0601F8B5 RID: 129205 RVA: 0x002EE53A File Offset: 0x002EC73A
		// (set) Token: 0x0601F8B6 RID: 129206 RVA: 0x002EE54E File Offset: 0x002EC74E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UObject> Object
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIPrefabOverrideParameterData.__PropertyOffset_Object);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIPrefabOverrideParameterData.__PropertyOffset_Object) = value;
			}
		}

		// Token: 0x17007C6C RID: 31852
		// (get) Token: 0x0601F8B7 RID: 129207 RVA: 0x002EE564 File Offset: 0x002EC764
		// (set) Token: 0x0601F8B8 RID: 129208 RVA: 0x002EE5A7 File Offset: 0x002EC7A7
		public TMap<FName, FGuid> MemberPropertyInfoMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FGuid> result;
				if ((result = this._MemberPropertyInfoMap) == null)
				{
					result = (this._MemberPropertyInfoMap = new TMap<FName, FGuid>(base.NativePtr + (IntPtr)FLGUIPrefabOverrideParameterData.__PropertyOffset_MemberPropertyInfoMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MemberPropertyInfoMap.CopyAssign(value);
			}
		}

		// Token: 0x0601F8B9 RID: 129209 RVA: 0x002EE5B5 File Offset: 0x002EC7B5
		public FLGUIPrefabOverrideParameterData()
		{
		}

		// Token: 0x0601F8BA RID: 129210 RVA: 0x002EE5BD File Offset: 0x002EC7BD
		public FLGUIPrefabOverrideParameterData([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UObject> Object, TMap<FName, FGuid> MemberPropertyInfoMap)
		{
			this.Object = Object;
			this.MemberPropertyInfoMap = MemberPropertyInfoMap;
		}

		// Token: 0x0601F8BB RID: 129211 RVA: 0x002EE5D3 File Offset: 0x002EC7D3
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIPrefabOverrideParameterData.StaticStruct();
		}

		// Token: 0x0601F8BC RID: 129212 RVA: 0x002EE5DF File Offset: 0x002EC7DF
		[NullableContext(2)]
		public FLGUIPrefabOverrideParameterData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8BD RID: 129213 RVA: 0x002EE5E9 File Offset: 0x002EC7E9
		public FLGUIPrefabOverrideParameterData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8BE RID: 129214 RVA: 0x002EE5F4 File Offset: 0x002EC7F4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIPrefabOverrideParameterData(Pointer, false, true);
		}

		// Token: 0x0601F8BF RID: 129215 RVA: 0x002EE5FE File Offset: 0x002EC7FE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIPrefabOverrideParameterData(Pointer, MemoryOwner);
		}

		// Token: 0x04011078 RID: 69752
		public const string __ObjectPath = "/Script/LGUI.LGUIPrefabOverrideParameterData";

		// Token: 0x04011079 RID: 69753
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401107A RID: 69754
		internal static int __PropertyOffset_Object;

		// Token: 0x0401107B RID: 69755
		internal static int __PropertyOffset_MemberPropertyInfoMap;

		// Token: 0x0401107C RID: 69756
		[Nullable(2)]
		private TMap<FName, FGuid> _MemberPropertyInfoMap;
	}
}
