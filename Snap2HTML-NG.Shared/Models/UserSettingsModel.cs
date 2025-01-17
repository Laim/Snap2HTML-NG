﻿using Snap2HTMLNG.Shared.Settings;
using System;

namespace Snap2HTMLNG.Shared.Models
{
    public class UserSettingsModel
    {
		private string _rootDirectory;

		public string RootDirectory
		{
			get { return _rootDirectory; }
			set { _rootDirectory = value; }
		}

		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private string _outputFile;

		public string OutputFile
		{
			get { return _outputFile; }
			set { _outputFile = value; }
		}

		private bool _skipHiddenItems;

		public bool SkipHiddenItems
		{
			get { return _skipHiddenItems; }
			set { _skipHiddenItems = value; }
		}

		private bool _skipSystemItems;

		public bool SkipSystemItems
		{
			get { return _skipSystemItems; }
			set { _skipSystemItems = value; }
		}

		private bool _openInBrowserAfterCapture;

		public bool OpenInBrowserAfterCapture
		{
			get { return _openInBrowserAfterCapture; }
			set { _openInBrowserAfterCapture = value; }
		}

		private bool _linkFiles;

		public bool LinkFiles
		{
			get { return _linkFiles; }
			set { _linkFiles = value; }
		}

		private string _linkRoot;

		public string LinkRoot
		{
			get { return _linkRoot; }
			set { _linkRoot = value; }
		}

		private string _searchPattern;

		public string SearchPattern
		{
			get { return _searchPattern; }
			set { _searchPattern = value; }
		}

		private bool _directoriesOnly;

		public bool DirectoriesOnly
		{
			get { return _directoriesOnly; }
			set { _directoriesOnly = value; }
		}

		private bool _checkForUpdates;

		public bool CheckForUpdates
		{
			get { return _checkForUpdates; }
			set { _checkForUpdates = value; }
		}

		private DateTime _fileDate;

		public DateTime FileDate
		{
			get { return _fileDate; }
			set { _fileDate = value; }
		}

		private FileDateOperator _fileDateOperator;

		public FileDateOperator FileDateOperator
		{
			get { return _fileDateOperator; }
			set { _fileDateOperator = value; }
		}

		private FileDateBasis _fileDateBasis;

		public FileDateBasis FileDateBasis
		{
			get { return _fileDateBasis; }
			set { _fileDateBasis = value; }
		}

		private bool _excludeEmptyDirectories;

		public bool ExcludeEmptyDirectories
		{
			get { return _excludeEmptyDirectories; }
			set { _excludeEmptyDirectories = value; }
		}



	}
}
