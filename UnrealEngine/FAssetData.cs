using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000705 RID: 1797
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.AssetData")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FAssetData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600614A RID: 24906 RVA: 0x0008B812 File Offset: 0x00089A12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetData._ScriptStructPtr != 0) ? FAssetData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AssetData", ref FAssetData._ScriptStructPtr);
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x0600614B RID: 24907 RVA: 0x0008B836 File Offset: 0x00089A36
		// (set) Token: 0x0600614C RID: 24908 RVA: 0x0008B84A File Offset: 0x00089A4A
		public unsafe FName ObjectPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_ObjectPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_ObjectPath) = value;
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x0008B85F File Offset: 0x00089A5F
		// (set) Token: 0x0600614E RID: 24910 RVA: 0x0008B873 File Offset: 0x00089A73
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x0008B888 File Offset: 0x00089A88
		// (set) Token: 0x06006150 RID: 24912 RVA: 0x0008B89C File Offset: 0x00089A9C
		public unsafe FName PackagePath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackagePath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_PackagePath) = value;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06006151 RID: 24913 RVA: 0x0008B8B1 File Offset: 0x00089AB1
		// (set) Token: 0x06006152 RID: 24914 RVA: 0x0008B8C5 File Offset: 0x00089AC5
		public unsafe FName AssetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetName) = value;
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x0008B8DA File Offset: 0x00089ADA
		// (set) Token: 0x06006154 RID: 24916 RVA: 0x0008B8EE File Offset: 0x00089AEE
		public unsafe FName AssetClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetData.__PropertyOffset_AssetClass) = value;
			}
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x0008B903 File Offset: 0x00089B03
		public FAssetData()
		{
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x0008B90B File Offset: 0x00089B0B
		public FAssetData(FName ObjectPath, FName PackageName, FName PackagePath, FName AssetName, FName AssetClass)
		{
			this.ObjectPath = ObjectPath;
			this.PackageName = PackageName;
			this.PackagePath = PackagePath;
			this.AssetName = AssetName;
			this.AssetClass = AssetClass;
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x0008B938 File Offset: 0x00089B38
		protected override IntPtr GetUStructPtr()
		{
			return FAssetData.StaticStruct();
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x0008B944 File Offset: 0x00089B44
		[NullableContext(2)]
		public FAssetData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x0008B94E File Offset: 0x00089B4E
		public FAssetData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x0008B959 File Offset: 0x00089B59
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetData(Pointer, false, true);
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x0008B963 File Offset: 0x00089B63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetData(Pointer, MemoryOwner);
		}

		// Token: 0x04002D81 RID: 11649
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.AssetData";

		// Token: 0x04002D82 RID: 11650
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D83 RID: 11651
		internal static int __PropertyOffset_ObjectPath;

		// Token: 0x04002D84 RID: 11652
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04002D85 RID: 11653
		internal static int __PropertyOffset_PackagePath;

		// Token: 0x04002D86 RID: 11654
		internal static int __PropertyOffset_AssetName;

		// Token: 0x04002D87 RID: 11655
		internal static int __PropertyOffset_AssetClass;
	}
}
